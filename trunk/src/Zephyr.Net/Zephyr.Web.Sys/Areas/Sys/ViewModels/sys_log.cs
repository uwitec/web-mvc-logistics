using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Zephyr.Web.Sys.Models
{
    public class sys_logService : ServiceBase<sys_log>
    {
        public void LoggerOperation(string position, string target, string type, object message)
        {
            var user = FormsAuth.GetLoginer();
            db.UseSharedConnection(true);
            db.Insert("sys_log")
                .Column("UserCode", user.UserCode)
                .Column("UserName", user.UserName)
                .Column("Position", position)
                .Column("Target", target)
                .Column("Type", type)
                .Column("Message", JsonConvert.SerializeObject(message))
                .Column("Date", DateTime.Now)
                .Execute();
        }
    }

    public class sys_log : ModelBase
    {
        [Identity]
        [PrimaryKey]
        public int ID { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string Position { get; set; }
        public string Target { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
        public DateTime? Date { get; set; }
    }
}
