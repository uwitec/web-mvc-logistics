using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;
using Zephyr.Web.Mms;

namespace Zephyr.Web.Mms.Models
{
	[Module("Mms")]
    public class mms_transferService : ServiceBase<mms_transfer>
    {
        protected override bool OnBeforeDelete(DeleteEventArgs arg)
        {
            arg.db.Delete("mms_transferDetail").Where("BillNo", arg.GetValue("BillNo")).Execute();
            return base.OnBeforeDelete(arg);
        }

        protected override bool OnBeforeEditForm(EditEventArgs arg)
        {
            arg.dataNew["ProjectCode"] = MmsHelper.GetCurrentProject();
            return base.OnBeforeEditForm(arg);
        }

        //todo
        ////生成批次信息及更新来源单剩余数量
        //protected override void OnAfterEdit(EditEventArgs arg)
        //{
        //    MmsService.HandlerBillBatchesAfterEdit<mms_transfer>(arg);
        //}
 
    }

    public class mms_transfer : ModelBase
    {

        [PrimaryKey]
        public string BillNo{ get; set; }
        public DateTime? BillDate{ get; set; }
        public string DoPerson{ get; set; }
        public string ProjectCode{ get; set; }
        public DateTime? TransferDate{ get; set; }
        public string WarehouseCode{ get; set; }
        public string MaterialType{ get; set; }
        public string ReceiveUnit{ get; set; }
        public string ReceivePerson{ get; set; }
        public decimal? TotalMoney{ get; set; }
        public string PayKind{ get; set; }
        public string PriceKind{ get; set; }
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
