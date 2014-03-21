using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zephyr.Core
{
    public class MySqlRegister : ISymbolRegister
    {
        public DbType dbType { get { return DbType.MySql; } }

        public void RegistSQL(Dictionary<string, ISqlMaker> dict)
        {
            dict["DtGreaterEqual"] = new DefaultSqlMaker("datediff('{p0}',{c}) <=0");
            dict["DtLessEqual"] = new DefaultSqlMaker("datediff('{p0}',{c}) >=0");
            dict["DateRange"] = new DateRangeSqlMaker('到', "datediff('{p0}',{c}) <=0", "datediff('{p0}',{c}) >=0");
            dict["MapChild"] = new DefaultSqlMaker("{c} in (select {c} from {p1} where FIND_IN_SET({p2}, GetChild('{p3}','{p0}')))");

        }

        public void RegistZQL(Dictionary<string, IZqlMaker> dict)
        {
            dict["isnull"] = new DefaultZqlMaker("ifnull({0},{1})");
            dict["getdate"] = new DefaultZqlMaker("sysdate()");
        }
    }
}
