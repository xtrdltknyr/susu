using System.Collections.Concurrent;
using System.ComponentModel.Design;

namespace Feladatsor
{
    internal class Program
    {
        static void Feladat1()
        {
            Console.WriteLine("Hello, World!");
        }
        static void Feladat2()
        {
            Console.Write("Kérlek, add meg a neved: ");
            string be = Console.ReadLine()!;

            Console.WriteLine($"Szióka, {be}");
        }
        static void Feladat3()
        {
            Console.Write("Adj egy számot plíz: ");
            string be = Console.ReadLine()!;
            int? num = null;
            do
            {
                try
                {
                    num = int.Parse(be);
                    Console.WriteLine(num * (long)2);
                    return;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ez nem lesz így jó...");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ekkora szám nem létezik.");
                }
                Console.Write("Próbáld újra xdddddd: ");
                be = Console.ReadLine();
            }
            while (num is null);
        }
        static void Feladat4()
        {
            Console.Write("ADjá egész számt! ");
            int be1 = int.Parse(Console.ReadLine()!);

            Console.Write("Adj még egy számot!! ");
            int be2 = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"A két szám összege és különbsége {be1 + be2}, {be1 - be2}");
            Console.Write($"Szorzata: {be1 * be2}");
            if (be1 != 0 && be2 != 0)
            {
                Console.Write($" és hányadosa... {be1 / be2}");
            }
        }
        static void Feladat5()
        {
            try
            {
                Console.Write("Egy számot ami egész és nem betű: ");
                int be1 = int.Parse(Console.ReadLine()!);

                Console.Write("Mégegy számot ami nem betű és egész pls különben meghalsz: ");
                int be2 = int.Parse(Console.ReadLine()!);

                if (be1 > be2)
                {
                    Console.WriteLine("Első ngyobb!!");
                }
                else if (be1 < be2)
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
        }
        static void Feladat6()
        {
            int num1 = Beker("Kérek számot: ");
            int num2 = Beker("Mégegyet: ");
            int num3 = Beker("És mégegyet...: ");


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

        static void Feladat7()
        {
            int a = Beker("Kérem a háromszög egyik oldalát: ");
            int b = Beker("Másikat: ");    
            int c = Beker("És a harmadikat: ");


            if(a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Ebből nagyon gyönyörű háromszöget szerkeszthetsz :)");
            }
            else
            {
                Console.WriteLine("Ez egy gyászos hulladék háromszög lesz.");
            }

        }

        static void Feladat8()
        {
            int num1 = Beker("Számot pls!!! ");
            int num2 = Beker("AAAAAAAAA!! ");

            Console.WriteLine($"A számtani és mértani?? közepe: {(double)(num1 + num2) / 2}");
        }

        static void Feladat9() 
        {
            int a = Beker("Add meg az egyenlet egyik együtthatóját: ");
            int b = Beker("Add meg az egyenlet másik együtthatóját: ");
            int c = Beker("Add meg az egyenlet harmadik együtthatóját: ");

            double dis = Math.Pow(b, 2)-4*a*c;

            if (dis >= 0) {
                Console.WriteLine("Az egyenletnek van megoldása.");
            }
            else
            {
                Console.WriteLine("Az egyenletnek nincs megoldása.");
            }
        }
        static void Feladat10()
        {
            int a = Beker("Add meg az egyenlet egyik együtthatóját: ");
            int b = Beker("Add meg az egyenlet másik együtthatóját: ");
            int c = Beker("Add meg az egyenlet harmadik együtthatóját: ");

            double dis = Math.Pow(b, 2) - 4 * a * c;

            double res1 = (b + Math.Sqrt(dis))/2;
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

        static void Feladat11()
        {
            int a = Beker("Add meg a háromszög egyik befogóját: ");
            int b = Beker("Add meg a 3szög másik befogóját!! ");

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            
            Console.WriteLine($"  -  A 3szög átfogója {c:F2}.");
        }

        static void Feladat12()
        {
            int a = Beker("Egyik él: ");
            int b = Beker("Másik él: ");
            int c = Beker("Harmadik él: ");

            int sur = (a * b)*2 + (b * c)*2 + (a * c)*2;
            int vol = a * b * c;

            Console.WriteLine($"A valami mérete: {sur} és {vol}");
        }

        static void Feladat13()
        {
            double radius = DoubleBeker("Add meg a kör átmérőjét: ");
            double r = radius / 2;

            Console.WriteLine($"A kör kerülete: {2*r*Math.PI:F2}, területe: {Math.Pow(r, 2)*Math.PI:F2}");         
        }
        static void Feladat14()
        {
            double r = DoubleBeker("Add meg a sugarat: ");
            double a = DoubleBeker("Add meg a szöget: ");

            double i = ((2*r * Math.PI) / 360) * a;

            Console.WriteLine($"A körcikk területe {(r * i) / 2:F2}, ív hossza {i:F2}");
        }


        static int Beker(string text)
        {
            Console.Write(text);
            string inp = Console.ReadLine()!;

            int? num = null;
            do
            {
                try
                {
                    num = int.Parse(inp);
                    return (int)num;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valami nem jó itt, gondold át!");
                }
                Console.ForegroundColor= ConsoleColor.White;
                Console.Write(text);
                inp = Console.ReadLine()!;
            }
            while (num is null);
            return 0;
        }
        static double DoubleBeker(string text)
        {
            Console.Write(text);
            string inp = Console.ReadLine()!;

            double? num = null;
            do
            {
                try
                {
                    num = double.Parse(inp);
                    return (double)num;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valami nem jó itt, gondold át!");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(text);
                inp = Console.ReadLine()!;
            }
            while (num is null);
            return 0;
        }
        static void Main(string[] args)
        {
            Feladat14();
        }
    }
}


