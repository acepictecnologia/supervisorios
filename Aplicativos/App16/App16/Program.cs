using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetWindowSize(50, 20);
            Console.Title = "Curso Supervisório - Visual C# (ACEPIC)!";

            Console.WriteLine("Demonstrando o uso da cláusula break.\n");

            for (int x = 1; x < 10; x++)
            {
                if (x == 5)
                    break;

                Console.WriteLine("Número " + x);
            }

            Console.WriteLine("Fim do laço for");

            Console.WriteLine("\nDemonstrando o uso da cláusula continue.\n");

            for (int x = 1; x < 10; x++)
            {
                if (x == 5)
                {
                    Console.WriteLine("Neste momento x = 5");
                    continue;
                }

                Console.WriteLine("Número " + x);
            }

            Console.ReadKey();
        }
    }
}
