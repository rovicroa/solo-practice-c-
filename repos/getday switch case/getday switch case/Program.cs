using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getday_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a day number (starting from 0 for Sunday): ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The day is " + getDay(num) + ".");
            Console.ReadLine();
        }

        static string getDay(int num)
        {
            string dayName;

            switch (num)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "You entered an invalid day number";
                    break;
            }
            return dayName;
        }
    }
}
