using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Web.Sys.Models
{
    public class sys_permissionService : ServiceBase<sys_permission>
    {
        protected override bool OnBeforeEditRow(EditEventArgs arg)
        {
            if (arg.tabIndex == 0 && arg.dataAction == OptType.Del)
            {
                db.Sql(@"delete from sys_rolePermissionMap where PermissionCode = @0"
                    , arg.dataNew.Value<string>("_id")).Execute();
            }
            return base.OnBeforeEditRow(arg);
        }
    }

    public class sys_permission : ModelBase
    {
        [PrimaryKey]
        public string PermissionCode{ get; set; }
        public string PermissionName{ get; set; }
        public string ParentCode{ get; set; }
        public string CreatePerson { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdatePerson { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
