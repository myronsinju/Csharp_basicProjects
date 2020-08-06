using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class222_230
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Current Date and Time is : ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            

            Console.WriteLine("please enter a number.");
            int answer = Convert.ToInt32(Console.ReadLine());


            double radius = 5.3;
            double area = Constants.Pi * (radius * radius);
            int var = 149476000 / Constants.SpeedOfLight; //
            Console.ReadLine();
        }
    }
}
//1. Prints the current date and time to the console.
//2. Asks the user for a number.
//3. Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.

//1. Create a const variable.
//2. Create a variable using the keyword "var".
//3. Chain two constructors together.