using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutVsRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ref
            int OutSideVar = 20;
            SomeFunction(ref OutSideVar);

            Console.WriteLine(OutSideVar);

            //Out
            int OutSideVariable = 20;
            SomeMoreFunction(out OutSideVariable);

            Console.WriteLine(OutSideVariable);

        }

        static void SomeFunction(ref int InsideVar)
        {
            InsideVar = InsideVar + 10;
        }

        static void SomeMoreFunction(out int InsideVariable )
        {
            InsideVariable = 0;
            InsideVariable = InsideVariable + 10;

        }
    }
}
