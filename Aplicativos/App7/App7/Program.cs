using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App7
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            double height;

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.Clear();

            Console.SetWindowSize(50, 15);
            Console.Title = "Curso Supervisório - Visual C# (ACEPIC)!";

            Console.Write("Entre com seu nome: ");
            name = Console.ReadLine();
            Console.Write("Entre com sua idade: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entre com seu peso (Kg): ");
            height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Seu nome é " + name);
            Console.WriteLine("Você tem " + age + " anos.");
            Console.WriteLine("E seu peso é de " + height + " Kg.");

            Console.ReadKey();
        }
    }
}
