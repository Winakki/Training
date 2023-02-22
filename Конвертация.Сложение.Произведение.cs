using System;
using System.ComponentModel.Design.Serialization;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)

        {
            string str;
            int a;int b;int c;

            Console.WriteLine("Введите 1 число");
             str = Console.ReadLine();
             a = Convert.ToInt32(str);

            Console.WriteLine("Введите 2 число");
            str = Console.ReadLine(); 
            b = Convert.ToInt32(str);

            Console.WriteLine("Введите 3 число");
            str = Console.ReadLine();
            c = Convert.ToInt32(str);

            int result1 = a + b + c;
            int result2 = a * b * c;

            Console.WriteLine(result1);
            Console.WriteLine(result2);
        
        }
    }
}
