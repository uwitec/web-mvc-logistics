using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zephyr.Utils;

namespace Zephyr.Core
{
    public interface IZqlMaker
    {
        string Handler(string[] args);
    }
 
    public abstract class ZqlMakerBase : IZqlMaker
    {
        public object[] Arguments;

        public abstract string Handler(string[] args);
        
        public string GetArgument(int index = 0)
        {
            return ConvertHelper.ToString(Arguments[index]);
        }
    }
}
