using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App05
{
    class Program
    {
        enum dias { domingo, segunda, terca, quarta, quinta, sexta, sabado };

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.Clear();

            Console.SetWindowSize(50, 30);
            Console.Title = "Curso Supervisório - Visual C# (ACEPIC)!";

            Console.WriteLine("Primeiro dia da semana: " + dias.domingo);
            Console.WriteLine("Segundo dia da semana: " + dias.segunda);
            Console.WriteLine("Terceiro dia da semana " + dias.terca);
            Console.WriteLine("Quarto dia da semana: " + dias.quarta);
            Console.WriteLine("Quinto dia da semana: " + dias.quinta);
            Console.WriteLine("Sexto dia da semana: " + dias.sexta);
            Console.WriteLine("Sétimo dia da semana: " + dias.sabado);

            Console.ReadKey();
        }
    }
}

