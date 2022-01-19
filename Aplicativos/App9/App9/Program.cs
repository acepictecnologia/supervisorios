using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App09
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1;
            int Num2;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetWindowSize(50, 15);
            Console.Title = "Curso Supervisório - Visual C# (ACEPIC)!";

            Console.Write("Entre com um número: ");
            Num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entre com outro numero: ");
            Num2 = Convert.ToInt32(Console.ReadLine());

            if (Num1 > Num2)
                Console.WriteLine("O primeiro número é maior que o segundo!");

            else
                Console.WriteLine("O segundo número é maior ou igual ao primeiro!");

            Console.ReadKey();
        }
    }
}

