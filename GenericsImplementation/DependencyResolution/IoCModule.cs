using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsImplementation.DependencyResolution
{
    class IoCModule : NinjectModule
    {
        public override void Load()
        {
            //Bind<IMailSender>().To<MailSender>();
            //Bind<ILogger>().To<MockLogger>();
        }
    }
}
