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
            DrawScreen(100, 40);
        }

        public static void DrawScreen(int colunas, int linhas)
        {
            DoColumn(colunas);
            DoLine(linhas, colunas);
            DoColumn(colunas);
            
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
    }
}
