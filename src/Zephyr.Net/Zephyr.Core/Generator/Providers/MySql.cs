using System;

namespace Zephyr.Core.Generator
{
    //取得表的方法
    public class MySqlGen : ISqlGen
    {
        //取得表名，返回字段TableName即可
        public string SqlGetTableNames()
        {
            return "select TABLE_NAME as TableName from information_schema.TABLES where TABLE_SCHEMA= database()";
        }

        //取得表结构，返回字段ColumnName、SqlTypeName、MaxLength、IsNullable、IsIdentity、IsPrimaryKey、Description即可
        public string SqlGetTableSchemas(string TableName)
        {
            var sql = String.Format(@"
select  column_name                          as ColumnName
       ,data_type                            as SqlTypeName
       ,character_maximum_length             as MaxLength
       ,(case when is_nullable = 'YES' then 1 else 0 end) as IsNullable
       ,(case when column_key  = 'PRI' then 1 else 0 end) as IsPrimaryKey
from information_schema.COLUMNS 
 where table_name = '{0}' 
 and table_schema = database()", TableName);

            return sql;
        }

        //只要返回字段column_name即可 如select xx as column_name from yy where tablename = 'name'
        public string SqlGetTableKeys(string TableName)
        {

            var sql = String.Format(@"
select column_name from information_schema.COLUMNS 
 where table_name = '{0}' 
 and table_schema = database()
 and column_key = 'PRI'", TableName.ToUpper());//tableName要大写

            return sql;
        }

    }
}
