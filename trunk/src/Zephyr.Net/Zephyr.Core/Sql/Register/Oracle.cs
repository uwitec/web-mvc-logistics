using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zephyr.Core
{
    public class OracleRegister : ISymbolRegister
    {
        public DbType dbType { get { return DbType.Oracle; } }

        public void RegistSQL(Dictionary<string, ISqlMaker> dict)
        {
             
        }

        public void RegistZQL(Dictionary<string, IZqlMaker> dict)
        {
            dict["isnull"] = new DefaultZqlMaker("nvl({0},{1})");
            dict["getdate"] = new DefaultZqlMaker("sysdate");
        }
    }
}
