using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 4, 2, 10, 38, 54 };

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetWindowSize(50, 15);
            Console.Title = "Curso Supervisório - Visual C# (ACEPIC)!";

            foreach (int x in num)
                Console.WriteLine("Número {0}.", x);
            Console.ReadKey();
        }
    }
}
