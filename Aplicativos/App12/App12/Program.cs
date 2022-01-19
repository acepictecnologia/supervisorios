using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetWindowSize(50, 22);
            Console.Title = "Curso Supervisório - Visual C# (ACEPIC)!";


            for (int x = 0; x < 10; x++)
                Console.WriteLine("Curso Supervisório!");

            Console.WriteLine();

            for (int y = 0; y < 10; y++)
                Console.WriteLine("Número {0}.", y);

            Console.ReadKey();
        }
    }
}
