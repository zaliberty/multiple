using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double drobnoeChislo = 10.10;
            Write(drobnoeChislo);
            int summa = Multiple(25, 55);
            Write(summa);

           Console.ReadKey();
        }

        static void Write(int x)
        {
            Console.WriteLine(x);
        }

        static void Write(double x)
        {
            Console.WriteLine(x);
        }


        static int Multiple(int x, int y)
        {
            int summa = x * y;
            return summa;
        }
    }
}
