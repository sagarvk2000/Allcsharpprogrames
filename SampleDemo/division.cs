﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemo
{
    internal class division
    {
        static void Main(string[] args)
        {
            int num1, num2, div = 0;
            Console.WriteLine("Enter the first number =");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number =");
            num2 = Convert.ToInt32(Console.ReadLine());
            div = num1/num2;
            Console.WriteLine($"Addition of {num1} and {num2} is {div}");
        }
    }
}
