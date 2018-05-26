using IoCProject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCProject.ConcreteImplementation
{
    class MailSender : IMailSender
    {
        private readonly ILogger logging;

        public MailSender(ILogger logging)
        {
            this.logging = logging;
        }

        public void Send(string toAddress, string subject)
        {
            Console.WriteLine($"Sending mail to [{toAddress}] with subject [{subject}]");

            logging.Log("Mail has been sent!");
        }
    }
}
