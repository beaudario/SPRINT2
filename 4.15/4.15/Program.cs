using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef aantal punten voor  wiskunde: ");
            int PuntenWiskunde = Convert.ToInt16(Console.ReadLine());

            Console.Write("Geef aantal punten voor  natuurkunde: ");
            int PuntenNatuurkunde = Convert.ToInt16(Console.ReadLine());

            Console.Write("Geef totaal aantal punten: ");
            int PuntenTotaal = Convert.ToInt16(Console.ReadLine());


            if (PuntenNatuurkunde >= 60 && PuntenWiskunde >= 60)
            {
                Console.WriteLine("Je mag deelnemen aan het examen.");
                Console.ReadKey();
            }

            if (PuntenNatuurkunde < 60 || PuntenWiskunde < 60 && PuntenNatuurkunde >= 40 && PuntenWiskunde >= 40) ;
            {
                if (PuntenTotaal >= 180)
                {
                    Console.WriteLine("Je mag deelnemen aan het examen.");
                }
                Console.WriteLine("Je mag niet deelnemen aan het examen.");
                Console.ReadKey();
            }
        }
    }
}
