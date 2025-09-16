using System.Collections.Concurrent;
using System.ComponentModel.Design;

namespace Feladatsor
{
    internal class Program
    {
        static void F1()
        {
            Console.WriteLine("Hello world!");
        }
        static void F2()
        {
            Console.Write("Kérlek, add meg a neved: ");
            string input = Console.ReadLine()!;

            Console.WriteLine($"Szióka {input}!");
        }
        static void F3()
        {
            Console.Write("Írj be egy számot: ");
            int? num = null;
            do
            {
                string input = Console.ReadLine()!;
                try
                {
                    num = int.Parse(input);
                    Console.WriteLine(num * (long)2);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Kérlek egy egész számot adj, ne betűt. Se tört számot, azt sem szeretjük.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ekkora szám szerény véleményem szerint nem létezik.");
                }
            }
            while (num is null);
        }
        static void F4()
        {
            int input1 = AskForInt("Kérek egy számot: ");

            int input2 = AskForInt("Mégegyet: ");

            Console.WriteLine($"A két szám összege és különbsége {input1 + input2}, {input1 - input2}");
            Console.Write($"Szorzata: {input1 * input2}");
            if (input1 != 0 && input2 != 0)
            {
                Console.Write($" és hányadosa... {input1 / input2}");
            }
        }
        static void F5()
        {
            /*
            try
            {
                Console.Write("Egy számot ami egész és nem betű: ");
                int input1 = int.Parse(Console.ReadLine()!);

                Console.Write("Mégegy számot ami nem betű és egész pls különben meghalsz: ");
                int input2 = int.Parse(Console.ReadLine()!);

                if (input1 > input2)
                {
                    Console.WriteLine("Első nagyobb!!");
                }
                else if (input1 < input2)
                {

                    Console.WriteLine("Második nagyobb!!!!");
                }
                else
                {
                    Console.WriteLine("1enlő");
                }


            }
            catch (Exception)
            {
                Console.WriteLine("megverlek");
            }
            */

            int input1 = AskForInt("Adj meg egy számot: ");
            int input2 = AskForInt("Adj meg mégegy számot: ");

            if (input1 > input2)
            {
                Console.WriteLine("Az első megadott szám nagyobb.");
            }
            else if (input1 < input2)
            {

                Console.WriteLine("A második megadott szám nagyobb.");
            }
            else
            {
                Console.WriteLine("A két szám egyenlő.");
            }
        }
        static void F6()
        {
            int num1 = AskForInt("Kérek számot: ");
            int num2 = AskForInt("Mégegyet: ");
            int num3 = AskForInt("És mégegyet...: ");


            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine($"Első num a legkisebb, a(z) {num1}");
            }
            else if (num1 > num2 && num3 > num2)
            {
                Console.WriteLine($"Második a legkisebb, azaz {num2}");
            }
            else
            {
                Console.WriteLine($"Harmadik a legkisebb, ami {num3}");
            }

        }

        static void F7()
        {
            int a = AskForInt("Kérem a háromszög egyik oldalát: ");
            int b = AskForInt("Másikat: ");
            int c = AskForInt("És a harmadikat: ");


            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Ebből nagyon gyönyörű háromszöget szerkeszthetsz :)");
            }
            else
            {
                Console.WriteLine("Ez egy gyászos hulladék háromszög lesz.");
            }

        }

        static void F8()
        {
            int num1 = AskForInt("Add meg az egyik számot: ");
            int num2 = AskForInt("Add meg a másik számot: ");

            Console.WriteLine($"A számtani és mértani?? közepe: {(num1 + num2) / 2.0}");
        }

        static void F9()
        {
            int a = AskForInt("Add meg az egyenlet egyik együtthatóját: ");
            int b = AskForInt("Add meg az egyenlet másik együtthatóját: ");
            int c = AskForInt("Add meg az egyenlet harmadik együtthatóját: ");

            double dis = Math.Pow(b, 2) - 4 * a * c;

            if (dis >= 0)
            {
                Console.WriteLine("Az egyenletnek van megoldása.");
            }
            else
            {
                Console.WriteLine("Az egyenletnek nincs megoldása. Szerintem.");
            }
        }
        static void F10()
        {
            int a = AskForInt("Add meg az egyenlet egyik együtthatóját: ");
            int b = AskForInt("Add meg az egyenlet másik együtthatóját: ");
            int c = AskForInt("Add meg az egyenlet harmadik együtthatóját: ");

            double dis = Math.Pow(b, 2) - 4 * a * c;

            double res1 = (b + Math.Sqrt(dis)) / 2;
            double res2 = (b - Math.Sqrt(dis)) / 2;

            if (dis >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Egyik megoldás {res1}, másik megoldás {res2}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("Ennek nem lesz megoldása...");
            }
        }

        static void F11()
        {
            int a = AskForInt("Add meg a háromszög egyik befogóját: ");
            int b = AskForInt("Add meg a 3szög másik befogóját!! ");

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine($"  -  A 3szög átfogója {c:F2}.");
        }

        static void F12()
        {
            int a = AskForInt("Egyik él: ");
            int b = AskForInt("Másik él: ");
            int c = AskForInt("Harmadik él: ");

            int sur = (a * b) * 2 + (b * c) * 2 + (a * c) * 2;
            int vol = a * b * c;

            Console.WriteLine($"A valami mérete: {sur} és {vol}");
        }

        static void F13()
        {
            double radius = AskForDouble("Add meg a kör átmérőjét: ");
            double r = radius / 2;

            Console.WriteLine($"A kör kerülete: {2 * r * Math.PI:F2}, területe: {Math.Pow(r, 2) * Math.PI:F2}");
        }
        static void F14()
        {
            double r = AskForDouble("Add meg a sugarat: ");
            double a = AskForDouble("Add meg a szöget: ");

            double i = ((2 * r * Math.PI) / 360) * a;

            Console.WriteLine($"A körcikk területe {(r * i) / 2:F2}, ív hossza {i:F2}");
        }
        static void F15() 
        {
            int input;
            do
            {
                input = AskForInt("Kérlek, adj meg egy pozitív egész számot: ");
                for (global::System.Int32 i = 0; i < input; i++)
                {
                    Console.Write($"{i} ");
                }
            }
            while (input <= 0);
        } 

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
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Szerintem ez nem egy szám.");
                }
            }
            while (num is null);
            Console.ResetColor();
            return num.Value;
        }
 
        static double AskForDouble(string text)
        {

            double? num = null;
            do
            {
                Console.Write(text);
                string inp = Console.ReadLine()!;
                try
                {
                    num = double.Parse(inp);
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nagy szám ez, nem tudok vele mit kezdeni...");
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Szerintem ez nem egy szám.");
                }
                Console.Write(text);
                inp = Console.ReadLine()!;
            }
            while (num is null);
            Console.ResetColor();
            return num.Value;

        }
        static void Main(string[] args)
        {
            F15();
        }
    }
}


