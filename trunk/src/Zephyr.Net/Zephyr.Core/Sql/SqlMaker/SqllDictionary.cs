using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Zephyr.Core
{
    public class SqlDictionary : Dictionary<DbType, Dictionary<string, ISqlMaker>>
    {
        public ISqlMaker this[DbType dbType,string symbol]
        {
            get
            {
                if (dbType == null || symbol == null)
                    return null;

                symbol = symbol.ToLower();

                if (this.ContainsKey(dbType) && this[dbType].ContainsKey(symbol))
                    return this[dbType][symbol];

                if (this.ContainsKey(DbType.Default) && this[DbType.Default].ContainsKey(symbol))
                    return this[DbType.Default][symbol];

                return null;
            }
            set
            {
                if (!this.ContainsKey(dbType) || this[dbType] == null)
                    this[dbType] = new Dictionary<string, ISqlMaker>();
 
                this[dbType][symbol.ToLower()] = value;
            }
        }

        public Dictionary<string, ISqlMaker> this[DbType dbType]
        {
            get
            {
                return base[dbType];
            }
            set
            {
                if (!base.ContainsKey(dbType) || base[dbType] == null)
                    base[dbType] = new Dictionary<string, ISqlMaker>();

                foreach (var key in value.Keys)
                    base[dbType][key.ToLower()] = value[key];
            }
        }
    }
}
