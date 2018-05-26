using IoCProject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCProject.ConcreteImplementation
{
    class MockLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Message has been logged {message}");
        }
    }
}
