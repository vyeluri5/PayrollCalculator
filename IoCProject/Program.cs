using IoCProject.ConcreteImplementation;
using IoCProject.DependencyResolution;
using IoCProject.Factory;
using IoCProject.Interface;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel(new IoCModule());

            var mailSender = kernel.Get<IMailSender>();

            MailService factory = new MailService(mailSender);
            factory.Handle("test@factorytesting.com");

            Console.ReadLine();
            
        }
    }
}
