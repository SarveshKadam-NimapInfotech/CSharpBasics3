using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarVsDynamicVsObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************Using Object***********");
            object aa = 12;
            // object bb = aa + 12;   Error

            object bb = (int)aa + 12;
            Console.WriteLine(bb);

            object cc = bb;
            Console.WriteLine(cc);


            Console.WriteLine("**********Using Var*************");
            var ab = 12;
            var ac = ab + 12;
            Console.WriteLine(ac);

            Console.WriteLine("**********Using Dynamic*************");
            dynamic ad = 12;
            dynamic ae = ad + 12;
            Console.WriteLine(ae);

            dynamic az = ae;
            Console.WriteLine(az);


        }
    }
}

   