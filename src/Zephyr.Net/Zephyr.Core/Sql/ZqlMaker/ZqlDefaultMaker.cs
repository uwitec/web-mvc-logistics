using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zephyr.Data;
using Zephyr.Utils;

namespace Zephyr.Core
{
    public class DefaultZqlMaker : ZqlMakerBase
    {
        public DefaultZqlMaker(params object[] arguments)
        {
             Arguments = arguments;
        }
  
        public override string Handler(string[] args)
        {
            var sql = this.GetArgument();
            return string.Format(sql, args);
        }
    }
}
