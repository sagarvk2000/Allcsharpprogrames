using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemo
{
    internal class calculate_percentage
    {
        static void Main(string[] args)
        {
            int sub1, sub2, sub3, total;
            double percentage;
            Console.WriteLine("Enter the math marks =");
            sub1 = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Enter english marks =");
            sub2 = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Enter science marks =");
            sub3 = Convert.ToInt32(Console.ReadLine());

            total = sub1 + sub2 + sub3;
            Console.WriteLine($"total {total}");
            percentage = (total / 3);
            Console.WriteLine($"percentage {percentage}");
        }
    }
}
