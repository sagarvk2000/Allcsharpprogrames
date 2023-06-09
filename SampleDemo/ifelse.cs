using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemo
{
    internal class ifelse
    {
        static void Main(string[] args)
        {
            //even or odd
            int n;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }

            //positive negative

            if (n > 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }

            //check 18 above for vote

            if (n >= 18)
            {
                Console.WriteLine("eligible for vote");
            }
            else
            {
                Console.WriteLine("not eligible for vote");
            }
        }
    }
}
