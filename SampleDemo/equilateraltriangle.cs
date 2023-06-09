using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//wap to calculate the area equilateral triangle

namespace SampleDemo
{
    internal class equilateraltriangle
    {
        static void Main(string[] args)
        {
            double a, area;
            Console.WriteLine("Enter a number");
            a = Convert.ToInt32(Console.ReadLine());

            area = (1.733 / 4) * a * a;

            Console.WriteLine("the area is ="+area);


        }
    }
}
