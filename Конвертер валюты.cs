using System;
using System.ComponentModel.Design.Serialization;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)

        {
            double RUB;
            double USD = 74.71;
            Console.WriteLine("Введите сумму перевода из RUB в USD");
            RUB = double.Parse(Console.ReadLine());
            

            double result_USD = (RUB / USD);

            Console.WriteLine(RUB + " RUB в USD = "+ Math.Round(result_USD,2));
        }
    }
}
