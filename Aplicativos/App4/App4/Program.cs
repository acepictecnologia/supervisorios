using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App04
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

            //******************* Matrizes multidimensionais *******************
            //Supondo Bimestre e nota
            int[,] nota_bi = new int[3, 4];
            string[] new_aluno = new string[] { "José", "Maria", "João" };

            //Aluno José
            nota_bi[0, 0] = 7;
            nota_bi[0, 1] = 8;
            nota_bi[0, 2] = 8;
            nota_bi[0, 3] = 10;

            //Aluno Maria
            nota_bi[1, 0] = 10;
            nota_bi[1, 1] = 9;
            nota_bi[1, 2] = 7;
            nota_bi[1, 3] = 10;

            //Aluno João
            nota_bi[2, 0] = 9;
            nota_bi[2, 1] = 10;
            nota_bi[2, 2] = 8;
            nota_bi[2, 3] = 7;

            Console.Clear();
            Console.WriteLine("Demonstração de Matrizes Multidimensionais");
            Console.WriteLine("Notas dos Alunos");

            Console.WriteLine("==========================================\n");
            Console.WriteLine("\nBim. 1");
            Console.WriteLine("Aluno: " + new_aluno[0] + ", Nota: " + nota_bi[0, 0]);
            Console.WriteLine("Aluno: " + new_aluno[1] + ", Nota: " + nota_bi[1, 0]);
            Console.WriteLine("Aluno: " + new_aluno[2] + ", Nota: " + nota_bi[2, 0]);
            Console.WriteLine("\nBim. 2");
            Console.WriteLine("Aluno: " + new_aluno[0] + ", Nota: " + nota_bi[0, 1]);
            Console.WriteLine("Aluno: " + new_aluno[1] + ", Nota: " + nota_bi[1, 1]);
            Console.WriteLine("Aluno: " + new_aluno[2] + ", Nota: " + nota_bi[2, 1]);
            Console.WriteLine("\nBim. 3");
            Console.WriteLine("Aluno: " + new_aluno[0] + ", Nota: " + nota_bi[0, 2]);
            Console.WriteLine("Aluno: " + new_aluno[1] + ", Nota: " + nota_bi[1, 2]);
            Console.WriteLine("Aluno: " + new_aluno[2] + ", Nota: " + nota_bi[2, 2]);
            Console.WriteLine("\nBim. 4");
            Console.WriteLine("Aluno: " + new_aluno[0] + ", Nota: " + nota_bi[0, 3]);
            Console.WriteLine("Aluno: " + new_aluno[1] + ", Nota: " + nota_bi[1, 3]);
            Console.WriteLine("Aluno: " + new_aluno[2] + ", Nota: " + nota_bi[2, 3]);

            Console.ReadKey();
        }
    }
}

