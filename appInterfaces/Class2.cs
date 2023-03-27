using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appInterfaces
{
    class ImplementationClass2 : ISampleInterface2
    {
        // Explicit interface member implementation:
        void ISampleInterface2.SampleMethod2(int num1)
        {
            int Numero = num1;
            Console.WriteLine("SOLO GUARDA LO QUE HAY DENTRO DE LOS PARAMETROS");
        }
    }
    
}
