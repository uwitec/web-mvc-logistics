/*************************************************************************
 * 文件名称 ：ParamQuery.cs                          
 * 描述说明 ：查询参数构建
 * 
 

 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
**************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Zephyr.Core
{
    public class ParamQuery
    {
        protected ParamQueryData data;

        public ParamQuery Select(string sql)
        {
            data.Select = sql;
            return this;
        }

        public ParamQuery Top(int top)
        {
            Paging(1, top);
            return this;
        }

        public ParamQuery From(string sql)
        {
            data.From = sql;
            return this;
        }

        public ParamQuery Where(Condition c)
        {
            data.Where.Add(c);
            return this;
        }
 
        public ParamQuery Where(Action<ConditionBuilder> builder)
        {
            var cb = new ConditionBuilder();
            builder(cb);
            data.Where.Add(cb.c);
            return this;
        }

        public ParamQuery Where(string column, object value)
        {
            var cb = new ConditionBuilder().And(column,value).Symbol("equal");
            data.Where.Add(cb.c);
            return this;
        }
   
        public ParamQuery ClearWhere()
        {
            data.Where.Clear();
            return this;
        }
 
        public ParamQuery GroupBy(string sql)
        {
            data.GroupBy = sql;
            return this;
        }

        public ParamQuery OrderBy(string order)
        {
            var sortOrder = order.Trim().Split(' ');
            if (!string.IsNullOrWhiteSpace(order))
            {
                string mainTable = null;
                data.Select.Trim().Split(',').ToList().ForEach(x => {
                    if (x.Trim().EndsWith("." + sortOrder[0])) sortOrder[0] = x;
                    if (x.Trim().EndsWith(".*")) mainTable = x.Split('.')[0];
                });

                if (mainTable !=null && mainTable.StartsWith("distinct", StringComparison.OrdinalIgnoreCase))
                    mainTable = mainTable.Substring(8);

                if (sortOrder[0].IndexOf(".") == -1 && !string.IsNullOrEmpty(mainTable))
                    sortOrder[0] = mainTable + "." + sortOrder[0];
            }

            data.OrderBy = string.Join(" ", sortOrder);
 
            return this;
        }

        public ParamQuery Having(string sql)
        {
            data.Having = sql;
            return this;
        }

        public ParamQuery Paging(int currentPage, int itemsPerPage)
        {
            data.PagingCurrentPage = currentPage;
            data.PagingItemsPerPage = itemsPerPage;
            return this;
        }

        public ParamQuery()
        {
            data = new ParamQueryData();
        }

        public static ParamQuery Instance()
        {
            return new ParamQuery();
        }

        public ParamQueryData GetData()
        {
            return data;
        }
     }
}
