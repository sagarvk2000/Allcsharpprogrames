using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//accept 5 sub marks find avg , total, percentage

namespace SampleDemo
{
    internal class calpercentage
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e ;
            double avg, percent, total;

            Console.WriteLine("enter a sub marks =");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b sub marks =");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter c sub marks =");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter d sub marks =");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter e sub marks =");
            e = Convert.ToInt32(Console.ReadLine());

            total = (a + b + c + d + e);
                Console.WriteLine( total);

            avg = (total / 5);
            Console.WriteLine(avg);

            percent = total*(500/100) ;
            Console.WriteLine(percent);

        }
    }
}
