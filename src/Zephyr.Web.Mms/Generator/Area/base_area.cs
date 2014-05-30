using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Web.Trade.Models
{
    [Module("Trade")]
    public class base_areaService : ServiceBase<base_area>
    {
       
    }

    public class base_area : ModelBase
    {
        [PrimaryKey]   
        public string keyid { get; set; }
        public string areacd { get; set; }
        public string parentcd { get; set; }
        public string areahelpcd { get; set; }
        public string areaname { get; set; }
        public string attreg { get; set; }
        public string isportid { get; set; }
        public string isdockid { get; set; }
        public string isairportid { get; set; }
        public string zoneid { get; set; }
        public string stateid { get; set; }
        public string CreatePerson { get; set; }
        public DateTime? createdate { get; set; }
        public string UpdatePerson { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}