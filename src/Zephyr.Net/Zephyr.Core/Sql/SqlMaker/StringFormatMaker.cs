using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zephyr.Utils;

namespace Zephyr.Core
{
    public class StringFormatSqlMaker : SqlMakerBase
    {
        public StringFormatSqlMaker(params object[] arguments)
        {
             Arguments = arguments;
        }
  
        public override string Handler(Condition c)
        {
            return string.Format(c.Column, c.Values);
        }
    }
}
