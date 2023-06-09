using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Accept two no find greater one

namespace SampleDemo
{
    internal class greaterno
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first number");
            b = Convert.ToInt32(Console.ReadLine());    

            if (a > b)
            {
                Console.WriteLine("a is grater="+a);
            }
            else
            {
                Console.WriteLine("b is greater="+b);
            }


        }
    }
}
