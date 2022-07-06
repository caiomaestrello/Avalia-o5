using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliação5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, a;

            for (i = 1; i <= 100; i++)
            {
                a = i % 2;
                if (a == 0)
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadKey();
        }
    }
}