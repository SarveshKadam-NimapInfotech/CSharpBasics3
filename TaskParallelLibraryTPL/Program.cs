using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibraryTPL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Thread o1 = new Thread(RunMillionIterations);
            //o1.Start();

            Parallel.For(0, 1000000, x => RunMillionIterations());

            Console.ReadLine();


        }

        static void RunMillionIterations()
        {
            string x = "";
            for(int iIndex = 0; iIndex < 1000000; iIndex++)
            {
                x = x + "s";
            }

        }
    }
}
