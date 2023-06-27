﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т01.Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayOfWeek = int.Parse(Console.ReadLine());
            string[] days =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };


            if (dayOfWeek >= 1 && dayOfWeek <= 7)
            {
                Console.WriteLine(days[dayOfWeek - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
