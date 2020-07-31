using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class195
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Hello user please input a day of the week");
                

                string userInput = Console.ReadLine();
                Enum.TryParse(userInput, out DaysOfTheWeek day);
                if(day.ToString() != userInput)
                {
                    throw new Exception();
                }
                Console.WriteLine("you chose this day " + day);
            }
            catch (Exception)
            {
                Console.WriteLine("Pleae enter an actual day of the week.");
            }
            Console.ReadLine();
        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
//1. Create an enum for the days of the week.
//2. Prompt the user to enter the current day of the week.
//3. Assign the value to a variable of that enum data type you just created.
//4. Wrap the above statement in a try/catch block and have 
//    it print "Please enter an actual day of the week." to the console if an error occurs.