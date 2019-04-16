using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //UserInput
            Console.Write("Geef getal 1: ");
            string getal1 = Console.ReadLine();
            int Getal1 = Convert.ToInt32(getal1);

            Console.Write("Geef getal 2: ");
            string getal2 = Console.ReadLine();
            int Getal2 = Convert.ToInt32(getal2);

            //ShowNumbers
            for (int i = Getal1; i <= Getal2; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
