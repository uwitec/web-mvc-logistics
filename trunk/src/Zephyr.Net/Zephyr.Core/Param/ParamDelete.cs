/*************************************************************************
 * 文件名称 ：ParamDelete.cs                          
 * 描述说明 ：删除参数构建
 * 
 

 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
**************************************************************************/

using System;

namespace Zephyr.Core
{
    public class ParamDelete
    {
        protected ParamDeleteData data;

        public ParamDelete From(string sql)
        {
            data.From = sql;
            return this;
        }

        public ParamDelete Where(Condition c)
        {
            data.Where.Add(c);
            return this;
        }

        public ParamDelete Where(Action<ConditionBuilder> builder)
        {
            var cb = new ConditionBuilder();
            builder(cb);
            data.Where.Add(cb.c);
            return this;
        }

        public ParamDelete Where(string column, object value)
        {
            var cb = new ConditionBuilder().And(column, value).Symbol("equal");
            data.Where.Add(cb.c);
            return this;
        }

        public ParamDelete ClearWhere()
        {
            data.Where.Clear();
            return this;
        }
  
        public ParamDelete()
        {
            data = new ParamDeleteData();
        }

        public static ParamDelete Instance()
        {
            return new ParamDelete();
        }

        public ParamDeleteData GetData()
        {
            return data;
        }
     }
}
