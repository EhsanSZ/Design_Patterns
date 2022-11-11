using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Console
{
    public class SendEmail
    {
        public void Send()
        {
            Console.WriteLine("Email Sended......!");
        }
    }
    public class SendEmailDecorator:SendEmail
    {
        private readonly SendEmail _sendEmail;
        public SendEmailDecorator(SendEmail sendEmail)
        {
            _sendEmail = sendEmail;
        }

        public void Send()
        {
            _sendEmail.Send();
            Savelog();
        }

        private void Savelog()
        {
            Console.WriteLine("Savelog  ......!");
        }
    }
}
