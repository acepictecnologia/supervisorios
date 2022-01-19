using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;              /*declara a variável com o nome idade do 
                                    tipo inteiro*/
            float media;            /*declara a variável media do tipo float 
                               	    ponto flutuante*/
            string nome;            //declara a variável nome do tipo string
            bool status;            //declara a variável status do tipo bool

            //Inicialização das variáveis
            idade = 30;
            nome = "José Carlos";
            status = true;
            media = 76.5F;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.Clear();
            Console.SetWindowSize(50, 30);
            Console.Title = "Curso Supervisório - Visual C#!";

            //Concatenação de strings.
            Console.WriteLine("Idade: " + idade + " anos");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Media: " + media);
            Console.WriteLine("Aprovado: " + status);

            Console.WriteLine(""); //Pula 1 linha
            Console.WriteLine(""); //Pula 1 linha

            Console.WriteLine(nome + ", " + idade + " anos, Media: " + media
                              + ", Aprovado: " + status);

            Console.WriteLine(""); //Pula 1 linha

            Console.WriteLine("Pressione um tecla para continuar...");
            Console.WriteLine(""); //Pula 1 linha
            Console.ReadKey();
            /****************************** Tipo Char **********************************/
            char letra = 'C';

            /**************************** Tipos inteiros *******************************/
            byte a = 185;            //inteiro de 8 bits não sinalizado           
            sbyte b = -94;           //inteiro de 8 bits sinalizado
            ushort d = 53897;        //inteiro de 16 bits não sinalizado 
            short c = -16764;        //inteiro de 16 bits sinalizado
            uint f = 2150250460;     //inteiro de 32 bits não sinalizado
            int e = 412323434;       //inteiro de 32 bits sinalizado
            ulong g = 123423453456;  //inteiro de 64 bits não sinalizado
            long h = -1232343454567; //inteiro de 64 bits sinalizado

            /***************************** Tipos decimais ******************************/
            decimal i = 10.65M;
            float j = 856.789F;
            double k = 6784.8909;

            Console.Clear();
            Console.WriteLine("Tipo de dados char");
            Console.WriteLine("==================");
            Console.WriteLine("");

            Console.WriteLine("char: " + letra);

            Console.WriteLine("");
            Console.WriteLine("Tipos de dados Inteiros");
            Console.WriteLine("=======================");
            Console.WriteLine("");

            Console.WriteLine("byte: " + a);
            Console.WriteLine("sbyte: " + b);
            Console.WriteLine("ushort: " + c);
            Console.WriteLine("short: " + d);
            Console.WriteLine("uint: " + e);
            Console.WriteLine("int: " + f);
            Console.WriteLine("ulong: " + g);
            Console.WriteLine("long: " + h);

            Console.WriteLine("");
            Console.WriteLine("Tipos de dados decimais");
            Console.WriteLine("=======================");
            Console.WriteLine("");

            Console.WriteLine("decimal: " + i);
            Console.WriteLine("float: " + j);
            Console.WriteLine("double: " + k);

            Console.ReadKey();
        }
    }
}
