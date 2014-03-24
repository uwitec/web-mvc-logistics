using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;
using System.ComponentModel.DataAnnotations;

namespace Zephyr.Web.Sys.Models
{
    public class sys_buttonService : ServiceBase<sys_button>
    {
        protected override bool OnBeforeEditRow(EditEventArgs arg)
        {
            if (arg.tabIndex == 0 && arg.dataAction == OptType.Del)
            {
                var ButtonCode = arg.dataNew["ButtonCode"].ToString();
                db.Sql(@"
                --ɾ����ɫ�˵���ťMap
                delete sys_roleMenuButtonMap 
                where ButtonCode = @0
                
                --ɾ���˵���ťMap
                delete sys_menuButtonMap 
                where ButtonCode =@0 ", ButtonCode).Execute();
            }

            return base.OnBeforeEditRow(arg);
        }
    }

    public class sys_button : ModelBase
    {
        [PrimaryKey]
        public string ButtonCode { get; set; }
        public string ButtonName { get; set; }
        public int? ButtonSeq { get; set; }
        public string Description { get; set; }
        public string ButtonIcon { get; set; }
        public string CreatePerson { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdatePerson { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
