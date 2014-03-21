using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zephyr.Core
{
    public interface ISymbolRegister 
    {
        DbType dbType { get; }
        void RegistSQL(Dictionary<string, ISqlMaker> dict);
        void RegistZQL(Dictionary<string, IZqlMaker> dict);
    }
}
