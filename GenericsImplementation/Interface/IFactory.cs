using GenericsImplementation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsImplementation.Interface
{
    public interface IFactory
    {
        T Create<T>(ILogger logger)
            where T : IFactory;
    }
}
