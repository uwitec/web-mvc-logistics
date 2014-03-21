using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zephyr.Data;
using Zephyr.Utils;

namespace Zephyr.Core
{
    public class DefaultSqlMaker : SqlMakerBase
    {
        public DefaultSqlMaker(params object[] arguments)
        {
             Arguments = arguments;
        }
  
        public override string Handler(Condition c)
        {
            var sql = this.GetArgument();
            sql = sql.Replace("{c}", c.Column);

            for (var i = 0; i < c.Values.Length; i++)
            {
                var index = i.ToString();
                var s = "{p" + index + "}";
                sql = sql.Replace(s, c.GetValue(i));     //handle  {p0} {p1}

                s = s.Replace("p", "@p");
                if (sql.Contains(s))                     //handle  {@p0} {@p1}
                {
                    sql = sql.Replace(s, "@p" + index);
                    c.Parameters.Add(new Parameter() { Name = "p" + index, Value = c.Values[i], ParameterType = DataTypes.Object, Direction = ParameterDirection.Input, Size = 0 });
                }
            }

            return sql;
        }
    }
}
