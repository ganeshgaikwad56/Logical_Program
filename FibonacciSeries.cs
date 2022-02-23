using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programing
{
    public class FibonacciSeries
    {
        public static void Fibonacci()
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.WriteLine("Enter The number of elements");
            number=Convert.ToInt32(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");
            for(i=2;i<number;i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
