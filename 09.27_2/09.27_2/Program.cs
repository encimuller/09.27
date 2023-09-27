using System.Xml.Schema;

namespace _09._27_2
{
    internal class Program
    {
        /*
         * X, O karakter a konzolon
         * X - W-A-S-D karakterekkel mozgathato
         * O - bal-jobb-fel-le karakterekel mozgathato
         * ha talalalkoznak game over
         * 
         */

        static void Main(string[] args)
        {
            int x_x = 10;
            int x_y = 10;

            int o_x = Console.WindowWidth - 10;
            int o_y = Console.WindowHeight - 10;

            Console.Clear();
            Console.CursorLeft = x_x;
            Console.CursorTop = x_y;
            Console.Write("X");

            Console.CursorLeft = o_x;
            Console.CursorTop = o_y;
            Console.Write("O");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.LeftArrow:
                    x_x--;
                    break;
                case ConsoleKey.UpArrow:
                    x_y--;
                    break;
                case ConsoleKey.RightArrow:
                    x_x++;
                    break;
                case ConsoleKey.DownArrow:
                    x_y++;
                    break;

                case ConsoleKey.A:
                    o_x--;
                    break;
                case ConsoleKey.D:
                    o_x++;
                    break;
                case ConsoleKey.S:
                    o_y++;
                    break;
                case ConsoleKey.W:
                    o_y--;
                    break;
            }
           
            if (x_x == o_x && x_y == o_y)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("GAME OVER");
                Console.ReadLine();
            }
        }
    }
}