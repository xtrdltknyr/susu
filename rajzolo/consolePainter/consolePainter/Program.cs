using System.Drawing;
using System.Security.Principal;

namespace consolePainter
{
    internal class Program
    {
        public static bool eraser = false;
        public static bool drawToggle = false;
        public static int bgColor = 0;
        public static int x = 0;
        public static int y = 0;
        public static int opacity = 0;
        public static string tool = "none";
        public static int color = 1;
        public static char[] shade = ['█', '▓', '▒', '░'];



        static void Main(string[] args)
        {
            Console.SetWindowSize(120, 51);
            Console.SetBufferSize(120, 51);
            Console.Title = "ConsolePainter PreBeta 1";
            //Console.WriteLine("ConsolePainter @ extrudált kenyér 2025 - All Rights Reserved\n\n");
            Console.WriteLine("\t   ______                       __     ____        _       __           \r\n\t  / ____/___  ____  _________  / /__  / __ \\____ _(_)___  / /____  _____\r\n\t / /   / __ \\/ __ \\/ ___/ __ \\/ / _ \\/ /_/ / __ `/ / __ \\/ __/ _ \\/ ___/\r\n\t/ /___/ /_/ / / / (__  ) /_/ / /  __/ ____/ /_/ / / / / / /_/  __/ /    \r\n\t\\____/\\____/_/ /_/____/\\____/_/\\___/_/    \\__,_/_/_/ /_/\\__/\\___/_/     \r\n                                        \\| An extrudált kenyér product. |/ \n");
            Thread.Sleep(500);
            Console.WriteLine($"\n -- Canvas Creation ! -- \n ? Strike <ESC> to quit.\n");
            Console.WriteLine($" - Please choose a Background Color:\n - 0 = Black\n - 1 = Dark Blue\n - 2 = Dark Green\n - 3 = Dark Cyan\n - 4 = Dark Red\n - 5 = Dark Magenta\n - 6 = Dark Yellow\n - 7 = Gray\n - 8 = Dark Gray\n - 9 = Blue\n - 10 = Green\n - 11 = Cyan\n - 12 = Red\n - 13 = Magenta\n - 14 = Yellow\n - 15 = White");
            Console.Write("\n ~ ");
            bgColor = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.BackgroundColor = (ConsoleColor)bgColor;
            Console.Clear();
            
            CreateUI();


            while (true)
            {
                if (!eraser)
                {
                    tool = "PENCIL";
                }
                else
                {
                    tool = "ERASER";
                }

                UpdateUI();
                Console.SetCursorPosition(x, y);
    
                var key = Console.ReadKey(true).Key;

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
                    case ConsoleKey.E:
                        eraser = !eraser;
                        Console.SetCursorPosition(x, y);
                        break;
                    case ConsoleKey.Spacebar:
                        Draw();
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    case ConsoleKey.Tab:
                        if(color < 15)
                        {
                            color++;
                        }
                        else
                        {
                            color = 1;
                        }
                        break;
                    case ConsoleKey.Q:
                        if(color > 1)
                        {
                            color--;
                        }
                        else
                        {
                            color = 15;
                        }
                        break;
                    case ConsoleKey.W:
                        if (opacity < 3)
                        {
                            opacity++;
                        }
                        else
                        {
                            opacity = 0;
                        }
                        break;
                     }
                if (Console.CapsLock)
                {
                    Draw();
                }
                Console.SetCursorPosition(x, y);
            }

        }

        static void CreateUI()
        {
            string[] op = ["100%", "75%", "50%", "25%"];

            // Border
            for (int i = 0; i < 51; i++)
            {
                for (int j = 101; j < 120; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(' ');
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            }
            for (int i = 0; i < 51; i++)
            {
                Console.SetCursorPosition(101, i);
                Console.Write('!');
            }

            // Tool display
            Console.SetCursorPosition(103, 1);
            Console.Write("Yo tool: ");
            Console.SetCursorPosition(105, 2);
            Console.Write(tool);
            // Color Display
            Console.SetCursorPosition(103, 4);
            Console.Write("Yo color: ");
            Console.SetCursorPosition(105, 6);
            Console.Write('█');
            Console.SetCursorPosition(105, 7);
            Console.Write('█');
            Console.SetCursorPosition(106, 6);
            Console.Write('█');
            Console.SetCursorPosition(106, 7);
            Console.Write('█');
            Console.SetCursorPosition(108, 6);
            Console.Write((ConsoleColor)color);
            Console.SetCursorPosition(110, 7);
            Console.Write(op[opacity]);
            // hints
            Console.SetCursorPosition(103, 40);
            Console.WriteLine("Tab - Cycle color");
            Console.SetCursorPosition(103, 41);
            Console.WriteLine("Q - same thing");
            Console.SetCursorPosition(103, 42);
            Console.WriteLine("W - Opacity");
            Console.SetCursorPosition(103, 43);
            Console.WriteLine("E - Switch tool");
            Console.SetCursorPosition(103, 44);
            Console.WriteLine("CapsLk - Thing");
            

        }
        static void UpdateUI()
        {
            string[] op = ["100%", "75%", "50%", "25%"];

            // tool
            Console.SetCursorPosition(105, 2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(tool);
            Console.ForegroundColor = (ConsoleColor)color;
            // color
            Console.SetCursorPosition(105, 6);
            Console.ForegroundColor = (ConsoleColor)color;
            Console.Write('█');
            Console.SetCursorPosition(105, 7);
            Console.ForegroundColor = (ConsoleColor)color;
            Console.Write('█');
            Console.SetCursorPosition(106, 6);
            Console.ForegroundColor = (ConsoleColor)color;
            Console.Write('█');
            Console.SetCursorPosition(106, 7);
            Console.ForegroundColor = (ConsoleColor)color;
            Console.Write('█');
            Console.SetCursorPosition(108, 6);
            Console.Write("           ");
            Console.SetCursorPosition(108, 6);
            Console.Write((ConsoleColor)color);
            Console.SetCursorPosition(110, 7);
            Console.Write("    ");
            Console.SetCursorPosition(110, 7);
            Console.Write(op[opacity]);
        }
        static void Draw()
        {
            if (eraser)
            {
                Console.Write(' ');
            }
            else
            {
                //if () {
                Console.Write(shade[opacity]);
                //}
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
