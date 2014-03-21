/*************************************************************************
 * 文件名称 ：NewKey.cs                          
 * 描述说明 ：采番类
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
    //采番
    public class NewKey
	{
        public static string datetime()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmssfffffff");
        }

        public static string guid()
        {
            //return Guid.NewGuid().ToString().Replace("-", "");
            //用标准的36位的key
            return Guid.NewGuid().ToString();
        }
 
        //最大值加一
        public static string maxplus(IDbContext db, string table, string field, ParamQuery pQuery)
        {
            var sqlWhere = " where 1 = 1 ";
 
            if (pQuery != null)
            {
                var conditions = pQuery.GetData().Where;
                conditions.ForEach(c => sqlWhere += c.ToSql( GetDbType(db), !string.IsNullOrWhiteSpace(sqlWhere)));
            }

            var dbkey = db.Sql(String.Format("select {{isnull,max({0}),0}} from {1} {2}", field, table, sqlWhere)).QuerySingle<string>();
            var cachedKeys = getCacheKey(table, field);
            var currentKey = maxOfAllKey(cachedKeys, ConvertHelper.ToString(dbkey));
            var key = ConvertHelper.ToString(currentKey + 1);
            SetCacheKey(table, field, key);
            return key;
        }

        private static DbType GetDbType(IDbContext db)
        {
            var sType = db.Data.Provider.ToString().Split('.').LastOrDefault().Replace("Provider", "");
            var dbType = ConvertHelper.ToEnum<DbType>(sType, DbType.Default);
            return dbType;
        }

        //日期时间加上N位数字加一
        public static string dateplus(IDbContext db, string table, string field,string datestringFormat,int numberLength)
        {
            var dbkey = db.Sql(String.Format("select {{isnull,max({0}),0}} from {1}", field, table)).QuerySingle<string>();
            var mykey = DateTime.Now.ToString(datestringFormat) + string.Empty.PadLeft(numberLength, '0');
            var cachedKeys = getCacheKey(table, field);
            var currentKey = maxOfAllKey(cachedKeys, ConvertHelper.ToString(dbkey), mykey);
            var key = ConvertHelper.ToString(currentKey + 1);
            SetCacheKey(table, field, key);
            return key;
        }
 
        private static string getCacheKey(string table, string field)
        {
            var tableKeys = getTableKeys(table);
            return getFieldKeys(tableKeys, field);
        }

        private static Dictionary<string, string> getTableKeys(string table)
        {
            var tableKeys = CacheHelper.GetCache(String.Format("currentkey_{0}", table)) as Dictionary<string, string>;
            if (null == tableKeys)
                tableKeys = new Dictionary<string, string>();

            return tableKeys;
        }

        private static string getFieldKeys(Dictionary<string, string> tableKeys, string field)
        {
            return tableKeys.ContainsKey(field) ? tableKeys[field] : "0";;
        }

        private static void SetCacheKey(string table, string field, string key)
        {
            var tableKeys = getTableKeys(table);
            var fieldKeys = getFieldKeys(tableKeys, field);
            tableKeys[field] = ConvertHelper.ToString(maxOfAllKey(fieldKeys,key));
            CacheHelper.SetCache(String.Format("currentkey_{0}", table), tableKeys);
        }

        private static Int64 maxOfAllKey(string cachedKeys, params string[] otherKey)
        {
            var keys = new List<string> {cachedKeys};
            keys.AddRange(otherKey);
            var max = keys.Max<object>(x => Zephyr.Utils.ConvertHelper.To<Int64>(x));
            return max;
        }
	}
}
