using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._12
{
    class Program
    {
        static void Main(string[] args)
        {
            //userInput
            Console.Write("Geef DD-MM-YYYY (bijv. 05-08-2017): ");
            string Date = Console.ReadLine();

            //Substring
            string yearNumber = Date.Substring(6, 4);
            string monthNumber = Date.Substring(3, 2);

            //ConvertToInt
            int YearNumber = Convert.ToInt16(yearNumber);
            int MonthNumber = Convert.ToInt16(monthNumber);

            //ShowWeekday
            DateTime dateValue = new DateTime(YearNumber, MonthNumber, 01);
            Console.WriteLine(dateValue.ToString("dddd"));
            Console.ReadKey();
        }
    }
}
