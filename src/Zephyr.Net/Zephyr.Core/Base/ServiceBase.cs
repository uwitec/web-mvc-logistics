/*************************************************************************
 * 文件名称 ：ServiceBase.cs                          
 * 描述说明 ：定义数据服务基类
 * 
 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
 **************************************************************************/

using System;
using System.Dynamic;
using Zephyr.Data;

namespace Zephyr.Core
{
    public class ServiceBase : ServiceBase<ModelBase>
    {
        public ServiceBase(string Module)
            : base(Module)
        {

        }
    }

    public partial class ServiceBase<T> where T : ModelBase, new()
    {
        public ServiceBase()
        {
            ModuleName = AttributeHelper.GetModuleAttribute(this.GetType());
        }

        public ServiceBase(string moduleName)
        {
            ModuleName = moduleName;
        }

        ~ServiceBase()
        {
            try
            {
                db.Dispose();
            }
            catch 
            { 
            }
        }

        public static ServiceBase<T> Instance()
        {
            return new ServiceBase<T>();
        }
 
        public int StoredProcedure(ParamSP param)
        {
            var result = 0;
            Logger("执存储过程", () => result = BuilderParse(param).Execute());
            return result;
        }

        public dynamic ScrollKeys(string key, string value, ParamQuery where=null)
        {
            dynamic result = new ExpandoObject();
            Logger("获取上一条下一条数据", () =>
            {
                var asc = key;
                var desc = key + " desc";
                Func<object, bool> IsEnable = x => !object.Equals(x, value);
                result.current = value;
                
                var pFirst = ParamQuery.Instance().Select(key).Top(1).OrderBy(asc);
                var pPrevious = ParamQuery.Instance().Select(key).Top(1).Where(c=>c.And(key,value).Symbol("less")).OrderBy(desc);
                var pNext = ParamQuery.Instance().Select(key).Top(1).Where(c=>c.And(key,value).Symbol("greater")).OrderBy(asc);
                var pLast = ParamQuery.Instance().Select(key).Top(1).OrderBy(desc);

                if (where != null)
                {
                    foreach (var c in where.GetData().Where)
                    {
                        pFirst.Where(c);
                        pPrevious.Where(c);
                        pNext.Where(c);
                        pLast.Where(c);
                    }
                }
 
                result.first = GetField<string>(pFirst, value);
                result.previous = GetField<string>(pPrevious, value);
                result.next = GetField<string>(pNext, value);
                result.last = GetField<string>(pLast, value);

                result.previousEnable = IsEnable(result.previous);
                result.nextEnable = IsEnable(result.next);  
                result.firstEnable = IsEnable(result.first); 
                result.lastEnable = IsEnable(result.last);  
            });
            return result;
        }

        public string GetNewKey(string field,string rule,int qty = 1,ParamQuery pQuery=null)
        {
            var result = string.Empty;

            Logger("获取新主键", () => { 
                for (var i = 0; i < qty; i++)
                {
                    string newkey, table = typeof(T).Name; ;
                    switch (rule)
                    {
                        case "guid":
                            newkey = NewKey.guid();
                            break;
                        case "datetime":
                            newkey = NewKey.datetime();
                            break;
                        case "dateplus":
                            newkey = NewKey.dateplus(db, table, field, "yyyyMMdd", 4);
                            break;
                        case "maxplus":
                        default:
                            newkey = NewKey.maxplus(db, table, field, pQuery);
                            break;
                    }

                    result += "," + newkey;
                }
            });

            return result.Trim(',');
        }

        #region 变量
        private IDbContext _db;
        protected IDbContext db { 
            get 
            { 
                if (_db==null)
                    _db = Db.Context(ModuleName);

                return _db;
            } 
        }
        public string ModuleName { get; set; }
        #endregion
    }
}
