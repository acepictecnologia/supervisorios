using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.Clear();

            Console.SetWindowSize(60, 30);
            Console.Title = "Curso Supervisório - Visual C# (ACEPIC)!";


            /***************** Operadores Aritiméticos *********************/
            decimal x = 4.65M, y = 6.75M;

            Console.WriteLine("Demonstração de Operadores Aritméticos");
            Console.WriteLine("======================================");
            Console.WriteLine("Adição       : {0} + {1} = {2}", x, y, x + y);
            Console.WriteLine("Subtração    : {0} - {1} = {2}", x, y, x - y);
            Console.WriteLine("Multiplicação: {0} * {1} = {2}", x, y, x * y);
            Console.WriteLine("Divisão      : {0} / {1} = {2}", x, y, x / y);

            Console.ReadKey();

            int a = 10, b = 5;

            Console.WriteLine("\nDemonstração de Operadores de Incremento e Decremento");
            Console.WriteLine("=====================================================\n");

            a++;    //a++ <=> a = a + 1
            b--;    //b-- <=> b = b - 1

            Console.WriteLine("Operador ++: a = {0}", a);
            Console.WriteLine("Operador --: b = {0}", b);
            Console.ReadKey();
        }
    }
}

