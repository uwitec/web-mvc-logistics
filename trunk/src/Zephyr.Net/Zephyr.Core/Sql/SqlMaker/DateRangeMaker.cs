using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zephyr.Utils;

namespace Zephyr.Core
{
    public class DateRangeSqlMaker : SqlMakerBase
    {
        public DateRangeSqlMaker(params object[] arguments)
        {
             Arguments = arguments;
        }

        public override string Handler(Condition c)
        {
            var spliteChar = (char)this.Arguments[0];

            var sSql = string.Empty;
            var from = this.Arguments[1].ToString();
            var to = this.Arguments[2].ToString();

            var values = c.GetValue().Split(spliteChar);
            var ignore = c.Ignore !=null && c.Ignore(c);

            if (values.Length == 1)
                values = new string[] { values[0], values[0] };

            if (!string.IsNullOrWhiteSpace(values[0]) || !ignore)
                sSql = from.Replace("{c}", c.Column).Replace("{p0}", values[0]);

            if (!string.IsNullOrWhiteSpace(values[1]) || !ignore)
                sSql += (sSql.Length > 0 ? " and " : string.Empty) + to.Replace("{c}", c.Column).Replace("{p0}", values[1]);

            return sSql;
        }
    }
}
