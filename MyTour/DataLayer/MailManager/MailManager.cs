using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace DataLayer.MailManager
{
    public static class MailManager
    {
        public static bool NewExpressionOfInterest(Contact contact)
        {
            try
            {
                MailMessage mail = new MailMessage();
               
                //mail.CC.Add(new MailAddress("rajeevkanth.m@gmail.com", "Rajeev"));
               
                mail.Subject = "Expression of interest";
                mail.Body = FormatMessage(contact);
                mail.IsBodyHtml = false;
                mail.From = new MailAddress("rajeevkanth1982@gmail.com");
                mail.To.Add("rajeevkanth.m@gmail.com");

                SmtpClient SmtpServer = new SmtpClient();
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential("rajeevkanth1982@gmail.com", "RA11**sh");
                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                SmtpServer.Host = "smtp.gmail.com";
                SmtpServer.Port = 587;
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        private static string FormatMessage(Contact contact)
        {
            var builder = new StringBuilder();
            builder.Append("From : ");
            builder.Append(contact.Name);
            builder.Append(Environment.NewLine);

            builder.Append("Mail : ");
            builder.Append(contact.Email);
            builder.Append(Environment.NewLine);

            builder.Append("Phone : ");
            builder.Append(contact.Phone);
            builder.Append(Environment.NewLine);

            builder.Append("Message : ");
            builder.Append(contact.Message);
            builder.Append(Environment.NewLine);

            return builder.ToString();
        }

    }
}
