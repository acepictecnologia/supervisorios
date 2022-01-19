using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App15
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 10;
            int num = 0;

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetWindowSize(50, 25);
            Console.Title = "Curso Supervisório - Visual C# (ACEPIC)!";

            do
            {
                Console.WriteLine("x = {0} e y = {1}", x, y);
                x++;
                y--;

            } while (y >= 0);

            do
            {
                Console.WriteLine("Entre com um número maior que 10: ");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num > 10);

        }
    }
}
