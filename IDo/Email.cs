﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace IDo
{
    internal class Email
    {
        public void Mail(String msg)
        {
            try
            {
                MailMessage mailMsg = new MailMessage();
                mailMsg.To.Add("magicmemers@hotmail.com");

                // From
                MailAddress mailAddress = new MailAddress("magicmemers@hotmail.com");
                mailMsg.From = mailAddress;

                // Subject and Body
                mailMsg.Subject = "IGAction";
                mailMsg.Body = msg;

                // Init SmtpClient and send on port 587 in my case. (Usual=port25)
                SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com", 587);
                System.Net.NetworkCredential credentials =
                   new System.Net.NetworkCredential("xxx@hotmail.com", "xxx");
                smtpClient.Credentials = credentials;
                smtpClient.EnableSsl = true;

                smtpClient.Send(mailMsg);
            }
            catch (Exception ex)
            {
             
            }
        }
    }
}
