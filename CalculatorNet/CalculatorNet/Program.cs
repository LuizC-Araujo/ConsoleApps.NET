using System;

namespace CalculatorNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
            
        }

        static void Menu()
        {   
            Console.Clear();
            Console.WriteLine("CALCULADORA!");
            Console.WriteLine("====================");
            Console.WriteLine("1 - SOMA");
            Console.WriteLine("2 - SUBTRAÇÃO");
            Console.WriteLine("3 - DIVISÃO");
            Console.WriteLine("4 - MULTIPLICAÇÃO");
            Console.WriteLine("5 - PORCENTAGEM");
            Console.WriteLine("6 - SAIR");
            Console.WriteLine("====================");
            Console.WriteLine("Escolha uma opção: "); 
            
            short resp = short.Parse(Console.ReadLine());

            switch (resp)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Porcentagem(); break;
                case 6: System.Environment.Exit(0); break;
                default: Menu(); break;
        
            }
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Valor 1:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"O valor da soma é {v1 + v2}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Valor 1:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"O valor da subtração é {v1 - v2}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.WriteLine("Valor 1:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"O valor da divisão é {v1 / v2}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Valor 1:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"O valor da multiplicação é {v1 * v2}");
            Console.ReadKey();
            Menu();

        }

        static void Porcentagem()
        {
            Console.WriteLine("Valor 1:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Quanto porcento do valor 1:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float perc = v1 * v2 / 100;
            Console.WriteLine($"{v2}% de {v1} é {perc}");
            Console.ReadKey();
            Menu();
        }
    }
}
