using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App14
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetWindowSize(50, 25);
            Console.Title = "Curso Supervisório - Visual C# (ACEPIC)!";

            while (i < 10)
            {
                Console.WriteLine("Curso Supervisório");
                i++;
            }

            i = 0;
            while (i <= 40)
            {
                Console.Write("=");
                i++;
            }

            Console.WriteLine();

            i = 10;
            while (i >= 0)
            {
                Console.WriteLine("i = {0}", i);
                i--;
            }
            Console.ReadLine();
        }
    }
}
