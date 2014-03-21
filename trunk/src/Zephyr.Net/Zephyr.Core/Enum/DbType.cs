/*************************************************************************
 * 文件名称 ：DbType.cs                          
 * 描述说明 ：数据库存类型
 * 
 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
**************************************************************************/

namespace Zephyr.Core
{
    public enum DbType
    {
        Default, //表示通用
        Access,
        DB2,
        MySql,
        Oracle,
        PostgreSql,
        SqlAzure,
        Sqlite,
        SqlServerCompact,
        SqlServer
    }
}
