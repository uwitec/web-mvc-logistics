using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Web.Trade.Models
{
    [Module("Trade")]
    public class base_lineService : ServiceBase<base_line>
    {
       
    }

    public class base_line : ModelBase
    {
        [PrimaryKey]   
        public string keyid { get; set; }
        public string linecd { get; set; }
        public string line { get; set; }
        public string bizlist { get; set; }
        public string stateid { get; set; }
    }
}