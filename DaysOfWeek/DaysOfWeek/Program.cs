using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Days of week list

            List<string> daysOfweek = new List<string>
            {
                "Monday",
                "Tuesday",
                "Wenesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };


            //Days of week Array

            /*string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wenesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            Console.WriteLine("Before: ");
            foreach (string day in daysOfWeek)
                Console.WriteLine(day);

            daysOfWeek[2] = "Wednesday";

            Console.WriteLine("\r\nAfter");
            foreach (string day in daysOfWeek)
                Console.WriteLine(day);*/


            /*Console.WriteLine("Which dat do you want to display?");
            Console.WriteLine("(Monday = 0, etc.) >");
            int iDay = int.Parse(Console.ReadLine());

            string chosenDay = daysOfWeek[iDay];
            Console.WriteLine($"That day is {chosenDay}");*/
        }
    }
}
