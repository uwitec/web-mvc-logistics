using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;
using Zephyr.Web.Mms;

namespace Zephyr.Web.Mms.Models
{
	[Module("Mms")]
    public class mms_directService : ServiceBase<mms_direct>
    {
        protected override bool OnBeforeDelete(DeleteEventArgs arg)
        {
            arg.db.Delete("mms_directDetail").Where("BillNo", arg.GetValue("BillNo")).Execute();
            return base.OnBeforeDelete(arg);
        }

        protected override bool OnBeforeEditForm(EditEventArgs arg)
        {
            arg.dataNew["ProjectCode"] = MmsHelper.GetCurrentProject();
            return base.OnBeforeEditForm(arg);
        }
    }

    public class mms_direct : ModelBase
    {

        [PrimaryKey]
        public string BillNo{ get; set; }
        public DateTime? BillDate{ get; set; }
        public string DoPerson{ get; set; }
        public string ProjectCode{ get; set; }
        public string SupplierCode{ get; set; }
        public string ContractCode{ get; set; }
        public string MaterialType{ get; set; }
        public DateTime? ArriveDate{ get; set; }
        public string PickUnit{ get; set; }
        public string BuildPartCode{ get; set; }
        public string PickPerson{ get; set; }
        public string SupplyType{ get; set; }
        public string PayKind{ get; set; }
        public string Purpose{ get; set; }
        public string OriginalNum{ get; set; }
        public decimal? TotalMoney{ get; set; }
        public string ApproveState{ get; set; }
        public string ApprovePerson{ get; set; }
        public DateTime? ApproveDate{ get; set; }
        public string ApproveRemark{ get; set; }
        public string CreatePerson{ get; set; }
        public DateTime? CreateDate{ get; set; }
        public string UpdatePerson{ get; set; }
        public DateTime? UpdateDate{ get; set; }
        public string Remark{ get; set; }
    }
}
