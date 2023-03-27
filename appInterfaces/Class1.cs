using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appInterfaces
{
    
    class ImplementationClass : ISampleInterface
    {
        // Explicit interface member implementation:
        void ISampleInterface.SampleMethod()
        {
            Console.WriteLine("NO RECIBE NI REGRESA NADA");
        }
    }
    
}
