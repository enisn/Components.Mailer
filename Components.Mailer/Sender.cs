using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Components.Mailer
{
    public class Sender
    {
        internal const string smtpAddress = "smtp.yandex.com";
        internal const int portNumber = 465;
        internal const bool enableSSL = true;

        internal const string emailFrom = "noreply@conetwork.info";
        internal const string password = "PASSWORD HERE";

        public static bool Send(string targetMail, string title, string content)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {

                    mail.From = new MailAddress(emailFrom);
                    mail.To.Add(targetMail);
                    mail.Subject = title;
                    mail.Body = content;
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFrom, password);
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                // throw ex;
                return false;
            }
        }
    }
}
