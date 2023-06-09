using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemo
{
    internal class prectangle_perimeter
    {
        static void Main(string[] args)
        {
            int l , b, peri = 0;
            Console.WriteLine("enter length");
            l = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter breadth");
            b = Convert.ToInt32(Console.ReadLine());

            peri = 2*(l+b);

            Console.WriteLine("The perimeter of rectangle is="+peri);
            
        }
    }
}
