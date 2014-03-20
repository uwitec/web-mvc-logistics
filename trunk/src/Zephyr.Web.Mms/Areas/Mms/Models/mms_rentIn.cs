using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;
using Zephyr.Web.Mms;

namespace Zephyr.Web.Mms.Models
{
	[Module("Mms")]
    public class mms_rentInService : ServiceBase<mms_rentIn>
    {
        //删除前删除子表
        protected override bool OnBeforeDelete(DeleteEventArgs arg)
        {
            arg.db.Delete("mms_rentInDetail").Where("BillNo", arg.GetValue("BillNo")).Execute();
            return base.OnBeforeDelete(arg);
        }

        //保存ProjectCode
        protected override bool OnBeforeEditForm(EditEventArgs arg)
        {
            arg.dataNew["ProjectCode"] = MmsHelper.GetCurrentProject();
            return base.OnBeforeEditForm(arg);
        }

        ////给RemainNum赋初始值
        protected override bool OnBeforeEditRow(EditEventArgs arg)
        {
            if (arg.tabIndex == 0)
            {
                if (arg.dataAction == OptType.Add)
                    arg.dataNew["RemainNum"] = arg.dataNew["Num"];
                else if (arg.dataAction == OptType.Mod)
                    arg.dataNew["RemainNum"] = arg.dataNew.Value<decimal>("Num") - (arg.dataOld.Num ?? 0) + (arg.dataOld.RemainNum ?? 0);
            }
            return base.OnBeforeEditRow(arg);
        }
    }

    public class mms_rentIn : ModelBase
    {

        [PrimaryKey]
        public string BillNo{ get; set; }
        public DateTime? BillDate{ get; set; }
        public string DoPerson{ get; set; }
        public string ProjectCode{ get; set; }
        public DateTime? RentInDate{ get; set; }
        public string SupplierCode{ get; set; }
        public string ContractCode{ get; set; }
        public string BuildPartCode{ get; set; }
        public string Purpose{ get; set; }
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
