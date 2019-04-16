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
            //Show1To25WithSquare
            for (int counter = 1; counter <= 25; counter++)
            {
                int square = counter * counter;
                Console.WriteLine(counter + square);
            }
            Console.ReadKey();
        }
    }
}
