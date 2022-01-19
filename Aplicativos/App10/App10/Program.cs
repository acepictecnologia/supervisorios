using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App10
{
    class Program
    {
        static void Main(string[] args)
        {
            int cor;

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetWindowSize(50, 15);
            Console.Title = "Curso Supervisório - Visual C# (ACEPIC)!";

            Console.WriteLine("Qual a sua cor preferida?");
            Console.WriteLine("[1] Azul");
            Console.WriteLine("[2] Verde");
            Console.WriteLine("[3] Vermelho");
            Console.WriteLine("[4] Amarelo");
            Console.WriteLine("[5] Preto");
            Console.WriteLine("[6] Nenhuma das alternativas.");
            Console.Write("\nEntre com a sua escolha: ");

            cor = Convert.ToInt32(Console.ReadLine());

            switch (cor)
            {
                case 1:
                    Console.WriteLine("Sua cor favorita é Azul.");
                    break;
                case 2:
                    Console.WriteLine("Sua cor favorita é Verde.");
                    break;
                case 3:
                    Console.WriteLine("Sua cor favorita é Vermelho.");
                    break;
                case 4:
                    Console.WriteLine("Sua cor favorita é Amarelo.");
                    break;
                case 5:
                    Console.WriteLine("Sua cor favorita é Preto.");
                    break;
                case 6:
                    Console.WriteLine("A sua cor favorita não está listada.");
                    break;
                default:
                    Console.WriteLine("Você não tem uma cor favorita.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
