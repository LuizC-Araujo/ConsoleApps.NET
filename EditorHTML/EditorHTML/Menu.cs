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
            DrawScreen();
        }

        public static void DrawScreen()
        {
            Console.Write("+");
            for(int i = 0; i < 30; i++)
                Console.Write("-");
            Console.Write("+");

            for(int lines = 0; lines < 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i < 30; i++)
                Console.Write("-");
            Console.Write("+");
        }
    }
}
