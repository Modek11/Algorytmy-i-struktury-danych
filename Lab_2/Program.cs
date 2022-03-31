using System;

namespace Lab_2 //Qubic Function
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            double w, p, q, delta;
            double u, v;
            double odpv;
            double x1, x2, x3;

            Console.WriteLine("Podaj a:");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b:");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c:");
            c = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj d:");
            d = Int32.Parse(Console.ReadLine());

            w = -b / (3 * a);
            p = ((3 * a * Math.Pow(w, 2)) + (2 * b * w) + c) / a;
            q = ((a * Math.Pow(w, 3)) + (b * Math.Pow(w, 2)) + (c * w) + d) / a;
            delta = (Math.Pow(q, 2) / 4) + (Math.Pow(p, 3) / 27);
            Console.WriteLine($"Delta: {delta}");

            if (delta > 0)
            {
                u = ((-q / 2) + Math.Sqrt(delta));
                u = Math.Pow(u, (1.0 / 3.0));

                v = (-q / 2) - Math.Sqrt(delta);
                Console.WriteLine($"V1: {v}");
                v = Math.Pow(v, (1.0 / 3.0));
                odpv = Math.Pow(v, (1.0 / 3.0));
                Console.WriteLine($"V2: {v}");
                x1 = u + v + w;

                //x1 = $"{u + v + w}";
                //x2 = $"{(-((u + v) / 2) + w)} + {(Math.Sqrt(3) / 2) * (u - v)}i";
                //x3 = $"{(-((u + v) / 2) + w)} - {(Math.Sqrt(3) / 2) * (u - v)}i";

                //Console.WriteLine(x1);
            }


        }
    }

}
