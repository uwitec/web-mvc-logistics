using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zephyr.Utils;

namespace Zephyr.Core
{
    public interface ISqlMaker
    {
        string Handler(Condition c);
    }

    public abstract class SqlMakerBase : ISqlMaker
    {
        public object[] Arguments;

        public abstract string Handler(Condition c);
        
        public string GetArgument(int index = 0)
        {
            return ConvertHelper.ToString(Arguments[index]);
        }
    }
}
