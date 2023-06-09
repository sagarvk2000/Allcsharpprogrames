using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemo
{
    internal class nary_operator
    {
        static void Main(string[] args)
        {
            int n ;
            Console.WriteLine("Enter a number=");
            n = Convert.ToInt32(Console.ReadLine());
           string res = (n > 0) ? "the number is positive" : "the number is negative";
            Console.WriteLine(res);
            

            


        }
    }
}
