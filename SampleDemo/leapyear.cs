﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//wap to find the leap year

namespace tqpracticequestions
{
    internal class leap_year
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("enter a year");
            year = Convert.ToInt32(Console.ReadLine());

            if(year%4 == 0)
            {
                Console.WriteLine("leap year");
            }
            else
            {
                Console.WriteLine("not a leap year");
            }

        }
    }
}
