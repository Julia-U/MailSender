﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender_v2
{
    public class DataBase
    {
        private static readonly EmailsDataContext _emailsDataContext = new EmailsDataContext();

        public static IQueryable<Emails> Emails =>
            from mail in
                _emailsDataContext.Emails
            select mail;
    }
}
