using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._6
{
  
        class Program
        {
            static void Main(string[] args)
            {
                //UserInput
                Console.Write("Geef aantal werkuren: ");
                int AantalWerkUren = Convert.ToInt16(Console.ReadLine());

                Console.Write("Geef levensjaar van de machine: ");
                int AantalJaren = Convert.ToInt16(Console.ReadLine());

                Console.Write("Geef aantal storingen voor dit jaar: ");
                int AantalStoringen = Convert.ToInt16(Console.ReadLine());
                
                //ShowOutcome
                if (AantalWerkUren >= 10000)
                {
                    Console.WriteLine("Machine moet vervangen worden.");
                    Console.ReadKey();
                }

                if (AantalJaren >= 7)
                {
                    Console.WriteLine("Machine moet vervangen worden.");
                    Console.ReadKey();
                }

                if (AantalStoringen >= 25)
                {
                    Console.WriteLine("Machine moet vervangen worden.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Geen vervanging nodig.");
                    Console.ReadKey();
                }

            }
        }
    }

