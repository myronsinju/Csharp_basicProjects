using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class234
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user what is your age?");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if (age == 0)
                {
                    Console.WriteLine("you cannot be 0 years old");
                }
                if (age < 0)
                {
                    Console.WriteLine("You cannot be a negative age ");
                }
                else
                {
                    DateTime birthdayYear = DateTime.Now.AddYears(-age);
                    Console.WriteLine("you were born in the year " + birthdayYear.Year);
                         //DateTime d2 = d1.AddYears(-2);
                }
            }
            catch(FormatException)  
            {
                Console.WriteLine("Please type a whole number with no words");
            }
            Console.ReadLine();
            
        }
    }
}
//1. Ask the user for their age.
//2. Display the year the user was born.
//3. Exceptions must be handled using "try .. catch".
//4. Display appropriate error messages if the user enters zero or negative numbers.
//5. Display a general message if an exception was caused by anything else.