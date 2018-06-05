using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// text for class TestClass
    public class TestClass
    {
        /// <summary><c>DoWork</c> is a method in the <c>TestClass</c> class.
        /// </summary>
        public void  DoWork(int Int1)
        {

        }

        /// text for Main
        static void Main()
        {
            int aTotal = 0;
            int bTotal = 0;

            int[] a = { 5,6,7 };

            int[] b = { 3, 6, 10 };

            for (int i=0; i<a.Length; i++)
            {
                if (a[i] > b[i])
                {
                    aTotal += 1;
                }
                else if (a[i] < b[i])
                {
                    bTotal += 1;
                }
            }

            int[] result = { aTotal, bTotal };

            Console.WriteLine(aTotal + " " + bTotal);

        }
    }
}
