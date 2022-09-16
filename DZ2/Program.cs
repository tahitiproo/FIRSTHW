using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            double exponenta = Math.Exp(1);
            double exp = Math.Round(exponenta, 1);
            Console.WriteLine(exp);
            Console.ReadKey();

        }
    }
}
