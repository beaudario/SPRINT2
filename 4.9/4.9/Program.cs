using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



   

namespace _4._9
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Geef maand nummer (bijv. 9): ");
                int MonthNumber = Convert.ToInt16(Console.ReadLine());

                DateTime DateValue = new DateTime(2000, MonthNumber, 1);
                Console.WriteLine(DateValue.ToString("MMMM"));
                Console.ReadKey();
            }
        }
    }

