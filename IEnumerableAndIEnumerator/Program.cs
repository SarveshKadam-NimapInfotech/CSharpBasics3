using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableAndIEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> oYears = new List<int>();
            oYears.Add(1990);
            oYears.Add(1991);
            oYears.Add(1992);
            oYears.Add(1993);
            oYears.Add(2001);
            oYears.Add(2002);
            oYears.Add(2003);

            //IEnumerable
            IEnumerable<int> ienum = (IEnumerable<int>)oYears;

            foreach (int i in ienum)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();


            //IEnumerator
            IEnumerator<int> ienumerat = oYears.GetEnumerator();

            while (ienumerat.MoveNext())
            {
                Console.WriteLine(ienumerat.Current.ToString());
            }

            Console.WriteLine();

            //Iterate19to20(ienumerat);
            Iterate19to20(ienum);
        }

        //-------------------------------------------------------------//
        static void Iterate19to20(IEnumerator<int> o)
        {
            while (o.MoveNext())
            {
                Console.WriteLine(o.Current.ToString());
                if (Convert.ToInt32(o.Current) > 2000)
                {
                    Iterate20andAbove(o);

                }
            }
        }

        static void Iterate20andAbove(IEnumerator<int> o)
        {
            while (o.MoveNext())
            {
                Console.WriteLine(o.Current.ToString());
            }
        }

        //------------------------------------------------------------------------//
        static void Iterate19to20(IEnumerable<int> o)
        {
            foreach (int i in o)
            {
                Console.WriteLine(i);
                if (i > 2000)
                {
                    Iterate20andAbove(o);

                }
            }
        }


        static void Iterate20andAbove(IEnumerable<int> o)
        {
            foreach (int i in o)
            {
                Console.WriteLine(i);
                
            }
        }





    }
}
