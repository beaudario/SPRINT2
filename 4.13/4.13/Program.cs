using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._13
{
    class Program
    {
        static void Main(string[] args)
        {
            var LastNumber = 0;

            Console.Write("Geef een getal: ");
            int Number = Convert.ToInt16(Console.ReadLine());

            var Square = Math.Pow(Number, 2);


            if (Number > 100)
            {
                LastNumber = Convert.ToInt32(Square) % 1000;
            }
            if (Number > 10)
            {
                LastNumber = Convert.ToInt32(Square) % 100;
            }
            if (Number <= 10)
            {
                LastNumber = Convert.ToInt32(Square) % 10;
            }


            if (LastNumber == Number)
            {
                Console.WriteLine(Number + " is een automorf getal.");
                Console.ReadKey();
            }
            if (LastNumber != Number)
            {
                Console.WriteLine(Number + " is geen automorf getal.");
                Console.ReadKey();
            }
        }
    }
}
