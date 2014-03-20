using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;
using Zephyr.Web.Mms;

namespace Zephyr.Web.Mms.Models
{
	[Module("Mms")]
    public class mms_returnService : ServiceBase<mms_return>
    {
        protected override bool OnBeforeDelete(DeleteEventArgs arg)
        {
            var billNo = arg.GetValue("BillNo");
            arg.db.Delete("mms_returnDetail").Where("BillNo", billNo).Execute();
            arg.db.Delete("mms_returnBatches").Where("BillNo", billNo).Execute();
            return base.OnBeforeDelete(arg);
        }

        protected override bool OnBeforeEditForm(EditEventArgs arg)
        {
            arg.dataNew["ProjectCode"] = MmsHelper.GetCurrentProject();
            return base.OnBeforeEditForm(arg);
        }
        //todo
       ////生成批次信息及更新来源单剩余数量
       // protected override void OnAfterEdit(EditEventArgs arg)
       // {
       //     MmsService.HandlerBillBatchesAfterEdit<mms_return>(arg);
       // }
    }

    public class mms_return : ModelBase
    {

        [PrimaryKey]
        public string BillNo{ get; set; }
        public DateTime? BillDate{ get; set; }
        public string DoPerson{ get; set; }
        public string ProjectCode{ get; set; }
        public DateTime? ReturnDate{ get; set; }
        public string MaterialType{ get; set; }
        public string WarehouseCode{ get; set; }
        public string SupplierCode{ get; set; }
        public string ContractCode{ get; set; }
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
