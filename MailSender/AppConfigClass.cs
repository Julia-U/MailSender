using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender
{
    // AppConfigClass.port_smpt_server = -45;

    public static class AppConfigClass
    {
        public static string smtp_server = "smtp.yandex.ru";
        
        private static int _port_smpt_server = 250;

        public static int port_smpt_server 
        {
            get 
            { 
                return _port_smpt_server;
            }
            set 
            {
                if (value > 0)
                {
                    _port_smpt_server = value;
                }
                else
                {
                    _port_smpt_server = 1;
                }               
            }
        }
    }
}