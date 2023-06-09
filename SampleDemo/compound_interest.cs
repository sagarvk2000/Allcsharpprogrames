using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Wap to calculate compound interest

namespace SampleDemo
{
    internal class compound_interest
    {
        static void Main(string[] args)
        {
            int p,n, t, r;
            double ci;

            Console.WriteLine("enter principle amount ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter n ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter time period ");
            t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter interest rate ");
            r = Convert.ToInt32(Console.ReadLine());

            ci = p * (1 + (r / n)) ^ n * t;
            Console.WriteLine(ci);


        }
    }
}
