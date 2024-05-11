using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using quanly_nhamayMinhChau.Service;

namespace quanly_nhamayMinhChau.Service
{
    internal class NhanVienSevice
    {
        SqlConnection conn;

        public void Add()
        {
            using (conn = Connection.GetConnection()) { }
        }
        public void Update()
        {
            using (conn = Connection.GetConnection()) { }
        }
        public void Delete()
        {
            using (conn = Connection.GetConnection()) { }
        }
        public void Search()
        {
            using (conn = Connection.GetConnection()) { }
        }

        public static void SendEmail(string toEmail)
        {

            var fromAddress = new MailAddress("anbum7733@gmail.com", "From Name");
            var toAddress = new MailAddress("trumkhomau@gmail.com", "To Name");
            const string fromPassword = "dbyc hqzw iiwm ywsx";
            const string subject = "Subject";
            const string body = "Body";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }

    }
}
