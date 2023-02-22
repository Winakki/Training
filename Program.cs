using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str2 = "5,9fd";
            double a;
            bool s = double.TryParse(str2, out a);
            if (s)
            {
                Console.WriteLine("Все успешно = " + a);
            }
            else
            {
                Console.WriteLine("Не получилось");
            }
          
           
        }
    }
}
