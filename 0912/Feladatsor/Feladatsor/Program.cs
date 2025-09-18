using System;

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
        static void F16()
        {
            int input;
            do
            {
                input = AskForInt("Kérlek, adj meg egy pozitív egész számot: ");
                for (global::System.Int32 i = 0; i < input; i++)
                {
                    Console.WriteLine($"{i} ");
                }
            }
            while (input <= 0);
        }
        static void F17()
        {
            int input = AskForInt("Add meg a számot, aminek az osztóját akarod tudni! ");

            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }
        static void F18()
        {
            int input = AskForInt("Add meg a számot, aminek az osztóját akarod tudni! ");
            int n = 0;
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                {
                    n += i;
                }
            }
            Console.WriteLine(n);
        }
        static void F19()
        {
            int input = AskForInt("Add meg a számot, amit ellenőrizzek: ");
            int n = 0;
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                {
                    n += i;
                }
            }
            if (n == input * 2)
            {
                System.Console.WriteLine("Ez egy tökéletes szám.");
            }
            else
            {
                System.Console.WriteLine("Ez egy szar szám.");
            }
        }
        static void F20()
        {
            int input1 = AskForInt("Add meg a hatványalapot: ");
            int input2 = AskForInt("Add meg a hatványkitevőt: ");

            System.Console.WriteLine($"A {Math.Pow(input1, input2)}");
        }
        static void F21()
        {
            double input = AskForDouble("Adj meg egy számot, ami pozitív: ");
            if (input > 0)
            {
                System.Console.WriteLine(":)");
            }
            else
            {
                System.Console.WriteLine("Ez csúnya volt tőled.");
            }
        }
        static void F22()
        {
            int input = AskForInt("Éhes vagyok, etess számokkal! ");
            int n = 0;
            while (input < 10)
            {
                n += input;
                input = AskForInt("Adj még! ");
            }
            if (n == 0)
            {
                System.Console.WriteLine("Túl erős kezdés.");
            }
            else
            {
                System.Console.WriteLine($"A 10-nél nagyobb számod nélkül az eredmény: {n}.");
            }
        }
        static void F23()
        {
            int input = AskForInt("Kérek egy egész számot: ");
            int n = 0;
            int num = 0;
            n = input % 2;
            num = input / 2;
            int prevNum = 0;
            if (input % 2 == 0)
            {
                while (n == 0)
                {
                    Console.Write("2*");
                    n = num % 2;
                    prevNum = num;
                    num = num / 2;
                }
                System.Console.Write(prevNum);
            }
            else
            {
                System.Console.WriteLine($"{input} = {input}");
            }

        }
        static void F24()
        {
            System.Console.Write("Adj meg egy szót: ");
            string input = Console.ReadLine()!;

            if (input == "alma")
            {
                System.Console.WriteLine("Az alma egy gyümölcs!");
            }
        }
        static void F25()
        {
            int input = AskForInt("Kérek egy egész számot! ");
            int n = 0;
            int num = input;

            while (num >= 3)
            {
                num = num -= 3;
                n++;
            }
            System.Console.WriteLine($"{input} = {n}*3+{num % 3}");
        }
        static void F26()
        {
            int input = AskForInt("Adj meg egy egész számot: ");
            int n = 0;
            for (int i = 2; i < Math.Sqrt(input); i++)
            {
                if (input % i == 0)
                {
                    n++;
                }
            }
            if (n == 0)
            {
                System.Console.WriteLine("A szám prímszám!");
            }
            else
            {
                System.Console.WriteLine("A szám nem prím!");
            }
        }
        static void F27()
        {
            int input = AskForInt("Adj meg egy egész számot: ");
            Console.Write("A ");
            for (int i = 0; i < input; i++)
            {
                int n = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        n++;
                    }
                }
                if (n == 0 && i > 2)
                {
                    System.Console.Write($"{i} ");
                }
            }
        }
        static void F28()
        {
            int input = AskForInt("Adj meg egy egész számot: ");
            for (int i = 1; i < input; i++)
            {
                int n = 0;
                if (input % i == 0)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            n++;
                        }
                    }
                    if (n == 0 && i > 2)
                    {
                        System.Console.Write($"{i} ");
                    }
                }
            }
        }
        static void F29()
        {
            int input = AskForInt("Adj meg egy egész számot: ");
            int n = input;
            int divider;
            while (n > 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0 && IsPrime(i))
                    {
                        divider = i;
                        Console.WriteLine($"\t{n}\t| {divider}");
                        n = n / i;
                    }
                }
            }
        }
        //F30
        static int LNKO(int input1, int input2)
        {
            //int input1 = AskForInt("Add meg az egyik számot: ");
            //int input2 = AskForInt("Add meg a másik számot: ");
            int a = input1 < input2 ? input1 : input2;
            int b = input1 > input2 ? input1 : input2;
            int result = 1;

            for (int i = a; i > 0; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    result = i;
                    break;
                }
            }
            return result;
            //Console.WriteLine($"A legnagyobb közös osztó: {result}");
        }
        static void F31()
        {
            int input1 = AskForInt("Add meg az egyik számot: ");
            int input2 = AskForInt("Add meg a másik számot: ");
            int lnko = LNKO(input1, input2);

            Console.WriteLine($"A legkisebb közös többszörös: {Math.Abs(input1*input2)/lnko}");
            
        }
        static void F32()
        {
            int input = AskForInt("Add meg a számot: ");
            
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{i * j * input}\t ");
                }
            }
        }
        static void F33()
        {
            int input = AskForInt("Add meg a számot: ");

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{i + j + input}\t ");
                }
            }
        }
        static void F34()
        {

        }
        static void F35()
        {
            for(byte i = 0;i < 255; i++)
            {   
                if (char.IsAsciiLetterLower((char)i))
                {
                    Console.Write($"{i}\t{(char)i}\t\t");
                }    
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------

        static bool IsPrime(int input)
        {
            int n = 0;
            bool prime = false;
            for (int i = 1; i < input; i++)
            {
                if (input % i == 0)
                {
                    n++;
                }
            }
            if (n == 1)
            {
                prime = true;
            }


            return prime;
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

        static double AskForDouble(string text)
        {

            double? num = null;
            do
            {
                Console.Write(text);
                string inp = Console.ReadLine()!.Replace('.', ',');
                try
                {
                    num = double.Parse(inp);
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
        static void Main(string[] args)
        {
            F35();
        }
    }
}


