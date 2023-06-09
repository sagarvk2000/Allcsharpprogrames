using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemo
{
    internal class even_odd
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter a no =");
            n = Convert.ToInt32 (Console.ReadLine());
            string res =  (n%2==0)?"the number is even":"the number is odd";
            Console.WriteLine(res);
        }
    }
}
