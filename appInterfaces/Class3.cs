using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appInterfaces
{
    
    class ImplementationClass3 : ISampleInterface3
    {
        // Explicit interface member implementation:
        int ISampleInterface3.SampleMethod3(int num2, int num3)
        {
            int suma;
            suma = num2 + num3;
            Console.WriteLine("LA SUMA DE LOS DOS NUMERO ES:" + suma);
            return suma;
        }
    }
    
}
