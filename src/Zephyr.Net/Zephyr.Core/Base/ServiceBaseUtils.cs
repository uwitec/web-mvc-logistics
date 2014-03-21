/*************************************************************************
 * 文件名称 ：ServiceBaseUtils.cs                          
 * 描述说明 ：定义数据服务基类中的工具类
 * 
 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using Zephyr.Data;
using Zephyr.Utils;

namespace Zephyr.Core
{
    public partial class ServiceBase<T> where T : ModelBase, new()
    {
        protected ISelectBuilder<T> BuilderParse(ParamQuery param)
        {
            if (param == null)
            {
                param = new ParamQuery();
            }

            var data = param.GetData();
           
            var from = data.From.Length == 0 ? typeof(T).Name : data.From;
            var select = string.IsNullOrEmpty(data.Select) ? (from + ".*") : data.Select;
            var where = GetSqlWhere(data.Where);

            var selectBuilder = db.Select<T>(select)
                .From(from)
                .Where(where)
                .GroupBy(data.GroupBy)
                .Having(data.Having)
                .OrderBy(data.OrderBy)
                .Paging(data.PagingCurrentPage, data.PagingItemsPerPage);

            var parameters = GetQueryParameters(data.Where);
            foreach(var p in parameters)
                selectBuilder.Parameter(p.Name, p.Value, p.ParameterType, p.Direction, p.Size);

            return selectBuilder;
        }

        protected IInsertBuilder BuilderParse(ParamInsert param)
        {
            var data = param.GetData();
            var insertBuilder = db.Insert(data.From.Length == 0 ? typeof(T).Name : data.From);

            var dict = App.GetDefaultForCreate();

            foreach (var column in data.Columns.Where(column => !dict.ContainsKey(column.Key)))
                insertBuilder.Column(column.Key, column.Value);
            
            var properties = ReflectionHelper.GetProperties(typeof(T));
            foreach (var item in dict.Where(item => properties.ContainsKey(item.Key.ToLower())))
                insertBuilder.Column(item.Key, item.Value);

            return insertBuilder;
        }

        protected IUpdateBuilder BuilderParse(ParamUpdate param)
        {
            var data = param.GetData();
            var from = data.Update.Length == 0 ? typeof(T).Name : data.Update;

            var updateBuilder = db.Update(from);

            var dict = App.GetDefaultForUpdate();
            foreach (var column in data.Columns.Where(column => !dict.ContainsKey(column.Key)))
                updateBuilder.Column(column.Key, column.Value);

            var properties = ReflectionHelper.GetProperties(typeof(T));
            foreach (var item in dict.Where(item => properties.ContainsKey(item.Key.ToLower())))
                updateBuilder.Column(item.Key, item.Value);

            var where = GetSqlWhere(data.Where);
            if (data.Where.Exists(x => x.Symbol != "equal"))
            {
                foreach (var c in data.Where.Where(x=>x.Symbol !="eqaul" && x.Parameters !=null && x.Parameters.Count>0))
                    throw new Exception(string.Format("更新条件中的{0}未实现参数化！", c.Symbol));
 
                updateBuilder.Where(where);
            }
            else
            {
                foreach (var c in data.Where)
                    updateBuilder.Where(c.Column, c.Values[0]);
            }
 
            return updateBuilder;
        }

        protected IDeleteBuilder BuilderParse(ParamDelete param)
        {
            var data = param.GetData();
            var from = data.From.Length == 0 ? typeof(T).Name : data.From;
            var deleteBuilder = db.Delete(from);

            var where = GetSqlWhere(data.Where);
            if (data.Where.Exists(x => x.Symbol != "equal"))
            {
                foreach (var c in data.Where.Where(x => x.Symbol != "eqaul" && x.Parameters != null && x.Parameters.Count > 0))
                    throw new Exception(string.Format("删除条件中的{0}未实现参数化！", c.Symbol));

                deleteBuilder.Where(where);
            }
            else
            {
                foreach (var c in data.Where)
                    deleteBuilder.Where(c.Column, c.Values[0]);
            }

            return deleteBuilder;
        }

        protected IStoredProcedureBuilder BuilderParse(ParamSP param)
        {
            var data = param.GetData();
            var spBuilder = db.StoredProcedure(data.Name);
            foreach(var item in data.Parameter)
                spBuilder.Parameter(item.Key, item.Value);

            foreach (var item in data.ParameterOut)
                spBuilder.ParameterOut(item.Key, item.Value);

            return spBuilder;
        }

        protected int queryRowCount(ParamQuery param, dynamic rows)
        {
            if (rows != null)
                if (null == param || param.GetData().PagingItemsPerPage == 0)
                    return rows.Count;

            var RowCountParam = param;
            var sql = BuilderParse(RowCountParam.Paging(1, 0).OrderBy(string.Empty)).GetSql();
            return db.Sql(@"select count(*) from ( " + sql + " ) tb_temp").QuerySingle<int>();
        }

        private string GetSqlWhere(List<Condition> condtions)
        {
            var sql = string.Empty;
            condtions.ForEach(c => sql += " " + c.ToSql(db, !string.IsNullOrWhiteSpace(sql)));
            return sql.Trim();
        }

        private List<Parameter> GetQueryParameters(List<Condition> condtions)
        {
            var parameters = new List<Parameter>();
            foreach (var c in condtions)
                if (c.Parameters!=null) 
                    parameters.AddRange(c.Parameters);
            return parameters;
        }
    }
}
