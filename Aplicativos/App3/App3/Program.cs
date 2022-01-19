using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            Console.SetWindowSize(50, 30);
            Console.Title = "Curso Supervisório - Visual C# (ACEPIC)!";

            int[] nota = new int[5];
            string[] aluno = new string[] { "Carlos", "João", "Laura",
                                       "Carla", "Alex" };


            nota[0] = 50;
            nota[1] = 75;
            nota[2] = 38;
            nota[3] = 89;
            nota[4] = 93;

            Console.WriteLine("Demonstração de Arrays Unidimensionais (Vetores)");
            Console.WriteLine("================================================");
            Console.WriteLine("");

            Console.WriteLine("Nota de " + aluno[0] + ": " + nota[0]);
            Console.WriteLine("Nota de " + aluno[1] + ": " + nota[1]);
            Console.WriteLine("Nota de " + aluno[2] + ": " + nota[2]);
            Console.WriteLine("Nota de " + aluno[3] + ": " + nota[3]);
            Console.WriteLine("Nota de " + aluno[4] + ": " + nota[4]);

            Console.WriteLine("\nPressione uma tecla para finalizar...");
            Console.ReadKey();
        }
    }
}

