using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }

        void funkcjaKwadratowa()
        {
            Console.WriteLine("Podaj:");
            Console.Write("a:"); double a = double.Parse(Console.ReadLine());
            Console.Write("b:"); double b = double.Parse(Console.ReadLine());
            Console.Write("c:"); double c = double.Parse(Console.ReadLine());

            double delta = (b * b) - (4 * a * c);
            double sdelta = Math.Sqrt(delta);
            double psdelta = Math.Sqrt(-delta);
            Console.WriteLine($"Delta: {delta}");

            if (delta == 0)
            {
                Console.WriteLine($"Wynik, x0: {-b * (2 * a)}");
            }
            else
            {
                if (delta > 0)
                {
                    Console.WriteLine($"Wynik, x1: {(-b - sdelta) / (2 * a)}, x2: {(-b + sdelta) / (2 * a)}");
                }
                else
                {
                    Console.WriteLine($"Wynik, x1: {(-b / (2 * a)) - (psdelta / (2 * a))}*i, x2: {(-b / (2 * a)) + (psdelta / (2 * a))}*i");
                }
            }
        }

        void dzielenie()
        {
            Console.WriteLine("Podaj a i b");

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double x = -b / a;
            Console.WriteLine($"Wynik: {x}");
        }
    }
}
