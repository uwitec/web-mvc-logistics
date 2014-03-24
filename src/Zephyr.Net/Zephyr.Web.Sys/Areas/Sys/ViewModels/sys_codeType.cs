using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;
using System.ComponentModel.DataAnnotations;

namespace Zephyr.Web.Sys.Models
{
    public class sys_codeTypeService : ServiceBase<sys_codeType>
    {
        protected override bool OnBeforeEditRow(EditEventArgs arg)
        {
            if (arg.tabIndex == 0 && arg.dataAction == OptType.Del)
            {
                var codeType = arg.dataNew.Value<string>("CodeType");
                db.Sql(@"delete from sys_code where codetype = @0", codeType).Execute();
            }
            
            return base.OnBeforeEditRow(arg);
        }
    }

    public class sys_codeType : ModelBase
    {
        [PrimaryKey]
        public string CodeType { get; set; }
        public string CodeTypeName { get; set; }
        public string Description { get; set; }
        public string Seq { get; set; }
        public string CreatePerson { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdatePerson { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
