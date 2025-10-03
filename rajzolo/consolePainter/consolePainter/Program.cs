using System.Security.Principal;

namespace consolePainter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(120, 51);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("Poo Drawing Program @ anyád 2025 - All Rights Reserved");
            Thread.Sleep(500);
            Console.WriteLine(/*$" -- Canvas Creation ! -- \n*/ "    ? Strike <ESC> to quit.");
            Thread.Sleep(500);
            Console.Clear();

            for (int i = 0; i < 50; i++)
            {
                Console.SetCursorPosition(101, i);
                Console.Write('#');
            }

            /*
            Console.WriteLine(" - Recommended: anyád | Maximum: 50x50");
            int inWidth = AskForInt(" ~ Width: ");
            int inHeight = AskForInt(" ~ Height: ");
            Console.WriteLine();
            Console.SetCursorPosition(4, 8);

            CreateCanvas(inWidth, inHeight);
            */

            int x = 0;
            int y = 0;

            Console.CursorVisible = false;
            while (true)
            {
                var key = Console.ReadKey(true).Key;
                Console.SetCursorPosition(x, y);
                Console.Write(' ');

                bool color = false;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (y > 0)
                        {
                            y--;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        if (y < 50)
                        {
                            y++;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case ConsoleKey.LeftArrow:
                        if (x > 0)
                        {
                            x--;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        if (x < 100)
                        {
                            x++;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case ConsoleKey.Spacebar:
                        color ^= true;
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
                Console.SetCursorPosition(x, y);
                Console.Write('¤');
                if (color)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }

            }
            

        }
        /*
        static void CreateCanvas(int width, int height)
        {   
            Console.SetCursorPosition (4, 6);
            for (int y = 1; y < width+1; y++)
            {
                for (int x = 1; x < height+1; x++)
                {
                    if (x == 1 || y == 1 || x == width || y == height)
                    {
                        Console.SetCursorPosition (x+2, y+6);
                        Console.Write("#");
                    }
                    else
                    {
                        Console.SetCursorPosition (x+2, y+6);
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                Console.SetWindowSize (width+30, height+10);
            }
        }
        */

        static int AskForInt(string text)
        {
            int? num = null;
            do
            {
                Console.Write(text);
                string inp = Console.ReadLine()!;
                try
                {
                    num = int.Parse(inp);
                }
                catch (OverflowException)
                { 
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nagy szám ez, nem tudok vele mit kezdeni...");
                    Console.ResetColor();

                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Szerintem ez nem egy szám.");
                    Console.ResetColor();
                }
            }
            while (num is null);
            Console.ResetColor();
            return num.Value;
        }

    }
}
