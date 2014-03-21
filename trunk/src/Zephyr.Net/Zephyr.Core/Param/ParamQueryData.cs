/*************************************************************************
 * 文件名称 ：ParamQueryData.cs                          
 * 描述说明 ：查询参数数据
 * 
 

 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
**************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using Zephyr.Utils;

namespace Zephyr.Core
{
    public class ParamQueryData
    {
        public int PagingCurrentPage { get; set; }
        public int PagingItemsPerPage { get; set; }
        
        public string Having { get; set; }
        public string GroupBy { get; set; }
        public string OrderBy { get; set; }
        public string From { get; set; }
        public string Select { get; set; }
        public List<Condition> Where { get; set; }
       
        public ParamQueryData()
        {
            Having = "";
            GroupBy = "";
            OrderBy = "";
            From = "";
            Select = "";
            Where = new List<Condition>();
            PagingCurrentPage = 1;
            PagingItemsPerPage = 0;
        }
    }
}
