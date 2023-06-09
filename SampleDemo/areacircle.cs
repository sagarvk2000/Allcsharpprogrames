using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SampleDemo
{
    internal class tqpractice
    {
        static void Main(string[] args)
        {
            double pi = 3.14, area, r;
            Console.WriteLine("enter radius");
            r = Convert.ToInt32(Console.ReadLine());

            area = pi * r * r;
            Console.WriteLine(area);
        }
    }
}
