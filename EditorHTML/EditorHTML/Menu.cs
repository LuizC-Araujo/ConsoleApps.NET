using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorHTML
{
    public class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;       
            DrawScreen(30, 10);

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen(int colunas, int linhas)
        {
            DoColumn(colunas);
            DoLine(linhas, colunas);
            DoColumn(colunas);

            WriteOptions();

        }

        public static void DoColumn(int colunas)
        {
            Console.Write("+");
            for (int i = 0; i < colunas; i++)
                Console.Write("-");
            Console.Write("+");
            Console.Write("\n");
        }

        public static void DoLine(int linhas, int colunas)
        {
            for (int lines = 0; lines < linhas; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= colunas - 1; i++)
                    Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");

               
            }
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("==============");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo: ");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 9);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }
}
