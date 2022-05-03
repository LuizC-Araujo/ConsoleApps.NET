 using System;
using System.Threading;

namespace Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            

            Console.WriteLine("Quando tempo deseja contar? Ex: 25s, 2m");

            string data = Console.ReadLine().ToLower();
            int time = int.Parse(data.Substring(0, data.Length - 1));
            char type = char.Parse(data.Substring(data.Length - 1));

            int multi = 1;

            if (type == 'm')
                multi = 60;

            if (time == 0)
                System.Environment.Exit(0);

            Console.WriteLine("===============");
            Console.WriteLine("1 - PROGRESSIVO");
            Console.WriteLine("2 - REGRESSIVO");
            Console.WriteLine("0 - SAIR);
            Console.WriteLine("===============");
            Console.WriteLine("Escolha uma opção: ");
            int tipo = int.Parse(Console.ReadLine());

            switch (tipo)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: PreStart(); StartProgressivo(time * multi); break;
                case 2: PreStart(); StartRegressivo(time * multi); break;
                default: Menu(); break;
            }
            

        }
        static void PreStart()
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(1000);
        }
        static void StartProgressivo(int time)
        {
            int currentTime = 0;
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronômetro finalizado!");
            Thread.Sleep(2500);
            Menu();
        }

        static void StartRegressivo(int time)
        {
            int currentTime = time;
            while (currentTime > 0)
            {
                Console.Clear();
                Console.WriteLine(currentTime);
                currentTime--;
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronômetro finalizado!");
            Thread.Sleep(2500);
            Menu();
        }
       

    }
}
