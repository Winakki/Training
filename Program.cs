﻿using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1.9";

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            double a = Convert.ToDouble(str,numberFormatInfo);

            Console.WriteLine(a);
        }
    }
}
