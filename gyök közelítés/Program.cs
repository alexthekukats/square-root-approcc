using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           double[] alma = new double[100000000];
            double pi = Math.Sqrt(2);
            alma[0] = pi /2;
            int x = 1;
            pi = 0;

            while (true)
            {
                
                    pi += 2;
                    pi = Math.Sqrt(pi);

                    alma[x] = pi / 2;

                    double alma2 = 0;
                    for (int n = 0; n < x; n++)
                    {
                        alma2 = alma[n] * alma[n + 1];
                    }
                        Console.WriteLine(((1 / alma2) * 2));
                        Console.ReadKey();
                x++;
            }
        }
    }
}
