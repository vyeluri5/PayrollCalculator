using GenericsImplementation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsImplementation.Factory
{
    class Factory : IFactory
    {
        public T Create<T>(ILogger logger) 
            where T : IFactory
        {
            throw new NotImplementedException();
        }
    }
}
