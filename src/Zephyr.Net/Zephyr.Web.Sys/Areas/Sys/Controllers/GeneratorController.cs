using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Newtonsoft.Json.Linq;
using Zephyr.Core;
using Zephyr.Core.Generator;
using Zephyr.Utils;

namespace Zephyr.Web.Sys.Controllers
{
    public class GeneratorController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }

    public class GeneratorApiController : ApiController
    {
        public IEnumerable<dynamic> GetConnectionStrings()
        {
            var result = new List<dynamic>();
            foreach (ConnectionStringSettings setting in ConfigurationManager.ConnectionStrings)
            {
                var database = (setting.ConnectionString.Split(';').Where(x => x.ToLower().StartsWith("database")).FirstOrDefault() ?? string.Empty).Split('=').Last();
                if (!string.IsNullOrEmpty(database))
                    result.Add(new { value = setting.Name, text = database });
            }

            return result;
        }

        public IEnumerable<dynamic> GetTables(string database)
        {
            if (string.IsNullOrEmpty(database) || database == "undefined") 
                return new List<string>();

            var SQLProvider = this.GetSQLProvider(database);
            var sql = SQLProvider.SqlGetTableNames();

            using (var db = Db.Context(database))
            {
                return db.Sql(sql).QueryMany<dynamic>();
            }
        }

        public IEnumerable<dynamic> GetColumns(string database,string table)
        {
            if (string.IsNullOrEmpty(database) || database == "undefined")
                return new List<string>();

            var SQLProvider = this.GetSQLProvider(database);
            var sql = SQLProvider.SqlGetTableSchemas(table);
         
            using (var db = Db.Context(database))
            {
                return db.Sql(sql).QueryMany<dynamic>();
            }
        }

        public void Post(JToken data)
        {
            var type = data.Value<string>("type");
            var database = data.Value<string>("database");
            var area = data.Value<string>("area");
            var table = data.Value<string>("table");
            var controller = data.Value<string>("controller");
            var path = data.Value<string>("path");
 
            var SQLProvider = this.GetSQLProvider(database);

            using (var db = Db.Context(database))
            {
                var Columns = db.Sql(SQLProvider.SqlGetTableSchemas(table)).QueryMany<TableSchema>();
                var Keys = db.Sql(SQLProvider.SqlGetTableKeys(table)).QueryMany<TableKey>().Select<TableKey, string>(x => x.column_name).ToList<string>();
                var Model = new
                {
                    Database = database,
                    Area = area,
                    TableName = table,
                    Columns = Columns,
                    PrimaryKeys = Keys,
                    Identity = Zephyr.Core.Generator.Util.GetIdentity(Columns),
                    Data = data
                };

                var modelCode = RenderCode(type, "Model", Model);
                var controllerCode = RenderCode(type, "Controller", Model);
                var viewCode = RenderCode(type, "View", Model);

                var codePath = path + controller + "/";
                FileHelper.SaveStreamToFile(GetStreamFromString(modelCode), GetFilePath(codePath, table + ".cs"));
                FileHelper.SaveStreamToFile(GetStreamFromString(controllerCode), GetFilePath(codePath, controller + "Controller.cs"));
                FileHelper.SaveStreamToFile(GetStreamFromString(viewCode), GetFilePath(codePath, "Index.cshtml"));

                if (this.Request.RequestUri.Host == "localhost")
                    System.Diagnostics.Process.Start(GetFilePath(codePath)); //如果是本地访问就直接打开文件夹

                #region 压缩打包
                //return new {
                //    model=modelCode,
                //    controller=controllerCode,
                //    view=viewCode 
                //};

                //using (var zip = new ZipFile())
                //{
                //    zip.AddEntry(table + ".cs", GetStreamFromString(modelCode));
                //    zip.AddEntry(controller + "Controller.cs", GetStreamFromString(controllerCode));
                //    zip.AddEntry("Index.cshtml", GetStreamFromString(viewCode));
                //    Stream zipStream = new MemoryStream();
                //    zip.Save(zipStream);
                //    FileHelper.DownloadFile(HttpContext.Current, zipStream, controller + "-Code.zip", 1024 * 1024 * 10);
                //}
                #endregion
            }
        }

        private Dictionary<string, string> dict = null;
        private string GetVirtualPath(string pageType, string codeType)
        {
            var str = "~/Areas/Sys/Views/Generator/Template{0}{1}.cshtml";
            var key = string.Join("-",pageType,codeType).ToLower();
            if (dict == null)
            {
                dict = new Dictionary<string, string>();
                dict["search-model"] = string.Format(str, "Common", "Model");
                dict["search-view"] = string.Format(str, "Search", "View");
                dict["search-controller"] = string.Format(str, "Search", "Controller");

                dict["edit-model"] = string.Format(str, "Common", "Model");
                dict["edit-view"] = string.Format(str, "Edit", "View");
                dict["edit-controller"] = string.Format(str, "Edit", "Controller");

                dict["searchedit-model"] = string.Format(str, "Common", "Model");
                dict["searchedit-view"] = string.Format(str, "SearchEdit", "View");
                dict["searchedit-controller"] = string.Format(str, "SearchEdit", "Controller");
            }

            return dict[key];
        }

        private string RenderCode(string pageType, string codeType, object model)
        {
            string result = string.Empty;
            var path = GetVirtualPath(pageType, codeType);
 
            var routeData = new RouteData();
            routeData.Values.Add("controller", "Generator");

            var controllerContext = new ControllerContext(new HttpContextWrapper(HttpContext.Current), routeData, new GeneratorController());
            controllerContext.Controller.ViewData.Model = model;
            
            var viewEngineResult = ViewEngines.Engines.FindView(controllerContext, path, null);
            var view = viewEngineResult.View;

            var sw = new StringWriter();
            var ctx = new ViewContext(controllerContext, view,controllerContext.Controller.ViewData,controllerContext.Controller.TempData,sw);
            view.Render(ctx, sw);
            result = sw.ToString().Trim("\r\n".ToCharArray());
            sw.Dispose();
            
            return result;
        }
 
        private Stream GetStreamFromString(string s)
        {
            MemoryStream stream = new MemoryStream();
            UTF8Encoding utf8 = new UTF8Encoding(true);
            StreamWriter writer = new StreamWriter(stream, utf8);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        private ISqlGen GetSQLProvider(string database)
        {
            var setting = ConfigurationManager.ConnectionStrings[database];
            if (setting == null)
                throw new Exception("数据库连接未在web.config中配置！");

            var SQLProvider = GenTables.GetGenProvider(setting.ProviderName);
            return SQLProvider;
        }

        private string GetFilePath(string path, string fileName = "")
        {
            var server = HttpContext.Current.Server;
            FileHelper.CreateDirectory(server.MapPath(path));
            return server.MapPath(path + fileName);
        }
 
        //private string GetTemplate(string pageType, string codeType)
        //{
        //    var templatePath = HttpContext.Current.Server.MapPath(String.Format("~/Areas/Sys/Template/{0}/{1}.cshtml",pageType,codeType));
        //    var template = FileHelper.ReadTxtFile(templatePath);
        //    return template;
        //}
    }
}
