using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Accept two angles find third angle

namespace SampleDemo
{
    internal class triangle
    {
        static void Main(string[] args)
        {
            int a, b, c, thirdangle;
            Console.WriteLine("enter first angle");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second angle");
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;
            thirdangle = 180 - c;
            Console.WriteLine(thirdangle);

        }
    }
}
