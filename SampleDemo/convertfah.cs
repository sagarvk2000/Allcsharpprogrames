using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//convert fahrenheit into celcious

namespace SampleDemo
{
    internal class conertfah
    {
        static void Main(string[] args)
        {
            double fah, cel;
            Console.WriteLine("Enter a fahrenheit temp");
            fah = Convert.ToInt32(Console.ReadLine());
             cel = (fah-32)*5/9;
            Console.WriteLine(cel);

           

        }
    }
}
