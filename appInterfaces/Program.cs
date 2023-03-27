using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appInterfaces
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare an interface instance.
            ISampleInterface obj = new ImplementationClass();
            ISampleInterface2 obj2 = new ImplementationClass2();
            ISampleInterface3 obj3 = new ImplementationClass3();


            // Call the member.
            obj.SampleMethod();
            obj2.SampleMethod2(2);
            obj3.SampleMethod3(5, 1);
            Console.ReadKey();

        }
    }


}

