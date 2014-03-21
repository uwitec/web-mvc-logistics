/*************************************************************************
 * 文件名称 ：RequestWrapper.cs                          
 * 描述说明 ：请求包装
 * 
 

 *            modify by liuhuisheng on 2013-11-11 for refactoring
 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
**************************************************************************/

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Zephyr.Utils;

namespace Zephyr.Core
{
    public partial class RequestWrapper
    {
        public ParamDelete ToParamDelete()
        {
            var pDelete = ParamDelete.Instance();
            pDelete.From(GetTableName());
            EachWhere(c => pDelete.Where(builder => BuildCondition(builder,c)));
            return pDelete;
        }

        public ParamInsert ToParamInsert()
        {
            var pInsert = ParamInsert.Instance();
            pInsert.Insert(GetTableName());
            EachColumn(IsUpdate:false ,handler:name=> pInsert.Column(name, this[name]));
            return pInsert;
        }

        public ParamUpdate ToParamUpdate()
        {
            var pUpdate = ParamUpdate.Instance();
            pUpdate.Update(GetTableName());
            EachColumn(IsUpdate: true, handler:name => pUpdate.Column(name, this[name]));
            EachWhere(c => pUpdate.Where(builder => BuildCondition(builder, c)));
            return pUpdate;
        }

        public ParamQuery ToParamQuery()
        {
            var rows = GetValue<int>("rows", 0);
            var page = GetValue<int>("page", 1);
            var orderby = string.Join(" ", GetValue("sort"), GetValue("order"));
            var select = GetConfigString("select");
            var groupby = GetConfigString("groupby");
            var having = GetConfigString("having");
            var from = GetTableName();

            if (string.IsNullOrWhiteSpace(orderby))
                orderby = GetConfigString("orderby");

            var pQuery = ParamQuery.Instance()
                .Select(select)
                .From(from)
                .GroupBy(groupby)
                .OrderBy(orderby)
                .Having(having)
                .Paging(page, rows);

            EachWhere(c => pQuery.Where(builder => BuildCondition(builder, c)));
            return pQuery;
        }
    }
}
