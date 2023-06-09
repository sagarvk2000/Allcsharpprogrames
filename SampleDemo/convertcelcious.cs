using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//convert temp celcious into fahrenheit

namespace SampleDemo
{
    internal class convertcelcious
    {
        static void Main(string[] args)
        {
            double cel, fah;
            Console.WriteLine("Enter a degree");
            cel = Convert.ToInt32(Console.ReadLine());

            fah = (cel*1.8)+32;

            Console.WriteLine(fah);
        }
    }
}
