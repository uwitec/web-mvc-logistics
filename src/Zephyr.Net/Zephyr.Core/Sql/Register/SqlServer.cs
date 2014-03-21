using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zephyr.Core
{
    public class SqlServerRegister : ISymbolRegister
    {
        public DbType dbType { get { return DbType.SqlServer; } }

        public void RegistSQL(Dictionary<string, ISqlMaker> dict)
        {
            dict["DtGreaterEqual"] = new DefaultSqlMaker("datediff(day,'{p0}',{c}) >=0");
            dict["DtLessEqual"] = new DefaultSqlMaker("datediff(day,'{p0}',{c}) <=0");
            dict["DateRange"] = new DateRangeSqlMaker('到', "datediff(day,'{p0}',{c}) >=0", "datediff(day,'{p0}',{c}) <=0");
            dict["Child"] = new DefaultSqlMaker("{c} in (select ID from [dbo].[GetChild]('{p0}','{p1}'))");
            dict["MapChild"] = new DefaultSqlMaker("{c} in (select {c} from {p1} where {p2} in (select ID from [dbo].[GetChild]('{p3}','{p0}')))");
            dict["StartWithPY"] = new DefaultSqlMaker("{c} like '{p0}%' or [dbo].[fun_getPY]({c}) like N'{p0}%'");
        }

        public void RegistZQL(Dictionary<string, IZqlMaker> dict)
        {
            dict["isnull"] = new DefaultZqlMaker("isnull({0},{1})");
            dict["getdate"] = new DefaultZqlMaker("getdate()");
        }
    }
}
