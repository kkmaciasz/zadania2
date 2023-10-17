
using System;
using System.Runtime.CompilerServices;

namespace cwiczenia2
{
    class Program
    {
        static void zad21_srednia()
        {
            int suma = 0;
            int pozytywna = 0;
            int ocena;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Podaj ocenę: ");
                ocena = Convert.ToInt32(Console.ReadLine());
                if (ocena >= 3 & ocena <= 5)
                {
                    suma += ocena;
                    pozytywna++;
                }
            }
            if (pozytywna == 0)
            {
                Console.Write("Brak ocen pozytywnych");
            }
            else
            {
                double srednia = suma / (double)pozytywna;
                Console.WriteLine("Śrenia z ocen pozytywnych wynosi: {0:N}", srednia);
            }
        }

        static void zad22_lokata()
        {
            Console.Write("Podaj kwotę: ");
            double Y = Double.Parse(Console.ReadLine());
            Console.Write("Podaj ilość lat: ");
            double X = Double.Parse(Console.ReadLine());
            for (int i = 0; i < X; i++)
            {
                Y = Y + (0.06 * Y);
            }
            Console.WriteLine($"Wartość inwestycji po {X} latach: {Y:N}");
        }

        static void zad23_minmax()
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Podaj liczbę: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > max)
                {
                    max = n;
                }
                if (n < min)
                {
                    min = n;
                }
            }
            Console.WriteLine("Maksymalna liczba z podanych to: {0}", max);
            Console.WriteLine("Minimalna liczba z podanych to: {0}", min);
        }

        static void zad25_silnia()
        {
            Console.Write("Podaj liczbę: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int silnia = 1;
            for (int i = 1; i <= n; i++)
            {
                silnia = silnia * i;
            }
            Console.WriteLine($"{n}! = {silnia}");
        }

        static int silnia(int x)
        {
            int p = 1;
            for (int i = 1; i <= x; i++)
            {
                p = p * i;
            }
            return p;
        }

        static void silnia_test()
        {
            Console.Write("Podaj liczbę: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int wynik = silnia(n);
            Console.WriteLine($"{n}! = {wynik}");
        }


        static bool pierwsza(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void zad26_pierwsza()
        {
            Console.WriteLine("Podaj liczbę : ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (pierwsza(n))
            {
                Console.WriteLine($"Liczba {n} jest liczbą pierwszą");
            }
            else
            {
                Console.WriteLine($"Liczba {n} nie jest liczbą pierwszą");
            }
        }

        static void zad27_liczby()
        {
            Console.WriteLine("Podaj a i b gdzie b > a (a,b): ");
            string[] liczby = Console.ReadLine().Split(",");
            int a = Convert.ToInt32(liczby[0]);
            int b = Convert.ToInt32(liczby[1]);
            if (a >= b)
            {
                Console.WriteLine("Niepoprawne dane!");
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    if (pierwsza(i))
                    {
                        Console.WriteLine($"{i}");
                    }
                }
            }
        }

        static void zad28_newton()
        {
            Console.WriteLine("Podaj n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj k: ");
            int k = Convert.ToInt32(Console.ReadLine());
            double wynik = silnia(n) / (silnia(k) * silnia(n - k));
            Console.WriteLine($"n po k wynosi: {wynik}");
        }

        static void Main(string[] args)
        {
            //zad21_srednia();
            //zad22_lokata();
            //zad23_minmax();
            //zad25_silnia();
            //silnia_test();
            //zad26_pierwsza();
            //zad27_liczby();
            //zad28_newton();
        }
    }
}

