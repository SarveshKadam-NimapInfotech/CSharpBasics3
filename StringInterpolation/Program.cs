using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string
            string s1 = "hello";
            string s2 = "world";
            Console.WriteLine(s1 + " " + s2);
            Console.WriteLine();

            //string builder
            StringBuilder sb = new StringBuilder();
            sb.Append('_', 10);
            sb.AppendLine();
            sb.Append("header");
            Console.WriteLine(sb);
            Console.WriteLine();


            //string interpolation
            int n1 = 10;
            int n2 = 30;
            string s;

            s = ("The Sum Of " + n1 + " and " + n2 + " is " + (n1 + n2));
            s = string.Format("The Sum of {0} and {1} is {2}", n1, n2, n1 + n2);
            s = ($"The Sum of {n1} and {n2} is {n1 + n2}");

            Console.WriteLine("The Sum Of " + n1 + " and " + n2 + " is " + (n1 + n2));
            Console.WriteLine("The Sum of {0} and {1} is {2}",n1,n2,n1+n2);
            Console.WriteLine($"The Sum of {n1} and {n2} is {n1+n2}");

            Console.WriteLine(string.IsNullOrEmpty(s));
        }
    }
}
