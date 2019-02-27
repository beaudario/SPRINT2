using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 1; counter <= 25; counter++)
            {
                int square = counter * counter;
                Console.WriteLine("{0}   {1}", counter, square);
            }
            Console.ReadKey();
        }
    }
}
