using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Linq;

namespace Zephyr.Web.Sys.Models
{
    public class sys_organizeService : ServiceBase<sys_organize>
    {
        public void RecursionDelete(string id)
        {
            db.UseTransaction(true);
            var pQuery = ParamQuery.Instance().Where("ParentCode", id);
            var list = base.BuilderParse(pQuery).QueryManyDynamic();
            foreach (var item in list)
                RecursionDelete(item.OrganizeCode);

            db.Sql(@"
-- 删除机构角色Map
delete from sys_organizeRoleMap where OrganizeCode = @0;

-- 删除用户机构Map
delete from sys_userOrganizeMap where OrganizeCode = @0", id).Execute();

            var pDelete = ParamDelete.Instance().Where("OrganizeCode", id);
            base.BuilderParse(pDelete).Execute();
            db.Commit();
        }

        public dynamic GetOrganizeRole(string organize)
        {
            var sql = String.Format(@"
select distinct A.RoleCode,A.RoleName
,(case when B.RoleCode is null then 'false' else 'true' end) as Checked
from sys_role A
left join sys_organizeRoleMap B on B.RoleCode = A.RoleCode and B.OrganizeCode = '{0}'", organize);
            return db.Sql(sql).QueryMany<dynamic>();
        }

        public void SaveOrganizeRoles(string OrganizeCode, JToken RoleList)
        {
            db.UseTransaction(true);
            Logger("设置机构角色", () =>
            {
                db.Delete("sys_organizeRoleMap").Where("OrganizeCode", OrganizeCode).Execute();
                foreach (JToken item in RoleList.Children())
                {
                    var RoleCode = item["RoleCode"].ToString();
                    db.Insert("sys_organizeRoleMap").Column("OrganizeCode", OrganizeCode).Column("RoleCode", RoleCode).Execute();
                }
                db.Commit();
            }, e => db.Rollback());
        }
    }

    public class sys_organize : ModelBase
    {
        [PrimaryKey]
        public string OrganizeCode { get; set; }
        public string ParentCode { get; set; }
        public string OrganizeSeq { get; set; }
        public string OrganizeName { get; set; }
        public string Description { get; set; }
        public string CreatePerson { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdatePerson { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
