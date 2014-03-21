using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zephyr.Core
{
    public class DefaultRegister : ISymbolRegister
    {
        public DbType dbType { get { return DbType.Default; } }

        public void RegistSQL(Dictionary<string, ISqlMaker> dict)
        {
            dict["Equal"] = new DefaultSqlMaker("{c}='{p0}'");
            dict["NotEqual"] = new DefaultSqlMaker("{c}<>'{p0}'");
            dict["Greater"] = new DefaultSqlMaker("{c}>'{p0}'");
            dict["GreaterEqual"] = new DefaultSqlMaker("{c}>='{p0}'");
            dict["Less"] = new DefaultSqlMaker("{c}<'{p0}'");
            dict["LessEqual"] = new DefaultSqlMaker("{c}<='{p0}'");
            dict["In"] = new DefaultSqlMaker("{c} in ({p0})");
            dict["Like"] = new DefaultSqlMaker("{c} like '%{p0}%'");
            dict["StartWith"] = new DefaultSqlMaker("{c} like '{p0}%'");
            dict["EndWith"] = new DefaultSqlMaker("{c} like '%{p0}'");
            dict["Between"] = new DefaultSqlMaker("{c} between '{p0}' and '{p1}'");
            dict["Map"] = new DefaultSqlMaker("{c} in (select {p0} from {p1} where {p0}='{p2}'");
            dict["Sql"] = new StringFormatSqlMaker();
        }

        public void RegistZQL(Dictionary<string, IZqlMaker> dict)
        {
            dict["isnull"] = new DefaultZqlMaker("isnull({0},{1})");
            dict["getdate"] = new DefaultZqlMaker("getdate()");
        }
    }
}
