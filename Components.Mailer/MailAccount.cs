using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Mailer
{
    public class MailAccount
    {
        /// <summary>
        /// For Example "smtp.google.com" or "smtp.yandex.com"
        /// </summary>
        public string StmpAddress { get; set; } = "smtp.google.com";
        /// <summary>
        /// PortNumber of your mailserver
        /// Gmail : 587
        /// Yandex: 465
        /// or your custom port
        /// </summary>
        public int PortNumber { get; set; }

        /// <summary>
        /// Use SSL in Connection
        /// </summary>
        public bool EnableSSL { get; set; }
        /// <summary>
        /// EmailAddress
        /// </summary>
        public string EmailAdress { get; set; }
        /// <summary>
        /// Email Password
        /// </summary>
        public string EmailPassword { get; set; }
        public MailAccount()
        {

        }
        public MailAccount(string stmp, int port, string email, string password)
        {
            StmpAddress = stmp; PortNumber = port; EmailAdress = email; EmailPassword = password;
        }
        public MailAccount(string stmp, int port, string email, string password,bool ssl):this(stmp,port,email,password)
        {
            EnableSSL = ssl;
        }
    }
}
