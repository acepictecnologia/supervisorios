using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.Clear();

            Console.SetWindowSize(50, 30);  //Largura x Altura
            Console.Title = "Curso Supervisório - Visual C#!";

            Console.WriteLine("Bem vindo ao Curso");
            Console.WriteLine("==================");
            Console.WriteLine("");

            Console.Write("Introdução à Linguagem C\n");
            Console.Write("ACEPIC");

            Console.ReadLine();


        }
    }
}
