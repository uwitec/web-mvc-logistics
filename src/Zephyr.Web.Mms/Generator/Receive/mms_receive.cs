﻿using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Web.Sys.Models
{
    [Module("Mms")]
    public class mms_receiveService : ServiceBase<mms_receive>
    {
       
    }

    public class mms_receive : ModelBase
    {
        [PrimaryKey]   
        public string BillNo { get; set; }
        public DateTime? BillDate { get; set; }
        public string DoPerson { get; set; }
        public string ProjectCode { get; set; }
        public string SupplierCode { get; set; }
        public string ContractCode { get; set; }
        public string WarehouseCode { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public string MaterialType { get; set; }
        public string SupplyType { get; set; }
        public decimal? TotalMoney { get; set; }
        public string PayKind { get; set; }
        public string OriginalNum { get; set; }
        public string ApproveState { get; set; }
        public string ApprovePerson { get; set; }
        public DateTime? ApproveDate { get; set; }
        public string ApproveRemark { get; set; }
        public string CreatePerson { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdatePerson { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Remark { get; set; }
    }
}