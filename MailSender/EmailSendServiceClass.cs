using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace MailSender
{
    public class EmailSendServiceClass
    {
        MailMessage mm;

        public void MailMessage(string subject, string body, string sender, string reciver)
        {
            mm = new MailMessage(sender, reciver);
            mm.Subject = subject;
            mm.Body = body;
            mm.IsBodyHtml = false;
        }

        public void SmtpClient()
        {
            SmtpClient sc = new SmtpClient(AppConfigClass.smtp_server, AppConfigClass.port_smpt_server);
            sc.EnableSsl = true;
            sc.DeliveryMethod = SmtpDeliveryMethod.Network;
            sc.UseDefaultCredentials = false;
            sc.Credentials = new NetworkCredential("отправитель@yandex.ru", "password");
            sc.Send(mm);
        }
    }
}
