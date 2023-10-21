using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Shop_system.Forms
{
    internal class EmailService
    {
        private string _smtpServer;
        private int _smtpPort;
        private string _smtpUsername;
        private string _smtpPassword;
        private bool _enableSsl;

        public EmailService(string smtpServer, int smtpPort, string smtpUsername, string smtpPassword, bool enableSsl = true)
        {
            _smtpServer = smtpServer;
            _smtpPort = smtpPort;
            _smtpUsername = smtpUsername;
            _smtpPassword = smtpPassword;
            _enableSsl = enableSsl;
        }

        public void SendEmail(string toAddress, string subject, string body)
        {
            if (!IsValidEmail(toAddress))
            {
                throw new ArgumentException("The provided email address is not in a valid format.Please use the correct email when registering");
            }

            using (var client = new SmtpClient(_smtpServer, _smtpPort))
            {
                client.EnableSsl = _enableSsl;
                client.Credentials = new NetworkCredential(_smtpUsername, _smtpPassword);

                using (var mailMessage = new MailMessage(_smtpUsername, toAddress, subject, body))
                {
                    client.Send(mailMessage);
                }
            }
        }



        public bool IsValidEmail(string email)
        {
            const string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
