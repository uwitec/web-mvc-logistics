using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Zephyr.Utils
{
    public class SMTPHelper
    {
        public static string MailSending(string ToEmails, string Title, string Body, string AttachPath, string MailUser, string MailName, string MailHost, string MailPwd)
        {
            //string MailUser = ConfigurationManager.AppSettings["MailUser"].ToString();
            //string MailName = ConfigurationManager.AppSettings["MailName"].ToString();
            //string MailHost = ConfigurationManager.AppSettings["MailHost"].ToString();
            //string MailPwd = ConfigurationManager.AppSettings["MailPwd"].ToString();
            MailAddress from = new MailAddress(MailUser, MailName);
            MailMessage mail = new MailMessage();
            mail.Subject = Title;
            mail.From = from;
            string[] mailNames = (ToEmails + ";").Split(new char[]
			{
				';'
			});
            string[] array = mailNames;
            for (int i = 0; i < array.Length; i++)
            {
                string name = array[i];
                if (name != string.Empty)
                {
                    string displayName;
                    string address;
                    if (name.IndexOf('<') > 0)
                    {
                        displayName = name.Substring(0, name.IndexOf('<'));
                        address = name.Substring(name.IndexOf('<') + 1).Replace('>', ' ');
                    }
                    else
                    {
                        displayName = string.Empty;
                        address = name.Substring(name.IndexOf('<') + 1).Replace('>', ' ');
                    }
                    mail.To.Add(new MailAddress(address, displayName));
                }
            }
            mail.Body = Body;
            mail.BodyEncoding = Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.Normal;
            if (AttachPath != "")
            {
                mail.Attachments.Add(new Attachment(AttachPath));
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
            }
            SmtpClient client = new SmtpClient();
            client.Host = MailHost;
            client.Port = 25;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(MailUser, MailPwd);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.Send(mail);
            return mail.ToString();
        }
    }
}