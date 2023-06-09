using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a  program to check whether a number is divisible by 5 and 11 or not 

namespace tqpracticequestions
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter a number =");
            a = Convert.ToInt32(Console.ReadLine());

            if(a%5==0 && a%11==0)
            {
                Console.WriteLine("divisible");
            }
            else
            {
                Console.WriteLine("non-divisible");
            }

        }
    }
}
