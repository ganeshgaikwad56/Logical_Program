using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programing
{
    public class PrimeNumber
    {
        public static void CheckPrimeNumber()
        {
            int n, i, m = 0, flag = 0;

            Console.WriteLine("Enter The Number");
            n =Convert.ToInt32(Console.ReadLine());

            m = n / 2;

            for (i = 2; i < m; i++)

            {
                if (n % i == 0)
                {
                    Console.WriteLine("Number is not prime");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("prime number");
        }
    }
}
