using System;

namespace Lab_2 //Qubic Function
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            double w, p, q, delta;
            double u, v, phi;
            string x1, x2, x3;

            /*Console.WriteLine("Podaj a:");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b:");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c:");
            c = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj d:");
            d = Int32.Parse(Console.ReadLine());*/


            a = -5;
            b = 3;
            c = -10;
            d = 5;

            w = -b / (3 * a);
            p = ((3 * a * Math.Pow(w, 2)) + (2 * b * w) + c) / a;
            q = ((a * Math.Pow(w, 3)) + (b * Math.Pow(w, 2)) + (c * w) + d) / a;
            delta = (Math.Pow(q, 2) / 4) + (Math.Pow(p, 3) / 27);
            //Console.WriteLine($"Delta: {delta}");

            if (delta > 0)
            {
                u = Math.Cbrt( -(q / 2) + Math.Sqrt(delta) );
                v = Math.Cbrt( -(q / 2) - Math.Sqrt(delta) );

                x1 = "" + Math.Round(u + v + w, 5);
                
                x2 = "" + Math.Round((-((u + v) / 2) + w),5);
                x2 += " + " + Math.Round((Math.Sqrt(3) / 2) * (u - v), 5);
                
                x3 = "" + Math.Round((-((u + v) / 2) + w),5);
                x3 += " - " + Math.Round((Math.Sqrt(3) / 2) * (u - v), 5);

                Console.WriteLine($"x1: {x1}");
                Console.WriteLine($"x2: {x2}i");
                Console.WriteLine($"x3: {x3}i");
            }

            if (delta < 0)
            {
                phi = Math.Acos(3 * q / (2 * p * Math.Sqrt(-p / 3.0)));
                x1 = "" + Math.Round(w + (2 * Math.Sqrt(p / 3.0) * Math.Cos(phi/3)), 5);
                x2 = "" + Math.Round(w + (2 * Math.Sqrt(p / 3.0) * Math.Cos(phi/3 * (2/3*Math.PI))), 5);
                x3 = "" + Math.Round(w + (2 * Math.Sqrt(p / 3.0) * Math.Cos(phi/3 * (4/3*Math.PI))), 5);

                Console.WriteLine($"x1: {x1}");
                Console.WriteLine($"x2: {x2}");
                Console.WriteLine($"x3: {x3}");
            }

            if(delta == 0)
            {
                x1 = "" + (w - 2 * Math.Cbrt(q / 2.0));
                x2 = "" + (w + Math.Cbrt(q / 2.0));

                Console.WriteLine($"x1: {x1}");
                Console.WriteLine($"x2,x3: {x2}");
            }

            void deltaZnak()
            {
                int odInt = -10;
                int doInt = 10;
                Random rnd = new Random();
                int a = rnd.Next(odInt, doInt);
                int b = rnd.Next(odInt, doInt);
                int c = rnd.Next(odInt, doInt);
                int d = rnd.Next(odInt, doInt);
                do
                {
                    w = -b / (3 * a);
                    p = ((3 * a * Math.Pow(w, 2)) + (2 * b * w) + c) / a;
                    q = ((a * Math.Pow(w, 3)) + (b * Math.Pow(w, 2)) + (c * w) + d) / a;
                    delta = (Math.Pow(q, 2) / 4) + (Math.Pow(p, 3) / 27);
                    Console.WriteLine("");
                } while (delta == 0);

                Console.WriteLine($"{a},{b},{c},{d}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }

}
