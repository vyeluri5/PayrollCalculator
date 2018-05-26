using IoCProject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCProject.ConcreteImplementation
{
    public class MockMailSender : IMailSender
    {
        public void Send(string toAddress, string subject)
        {
            Console.WriteLine($"Mocking mail to [{toAddress}] with subject [{subject}]");
        }
    }
}
