using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Comparisons_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nAnonymous Income Comparison Program");
            Console.WriteLine("\nPerson 1");
            Console.WriteLine("hours worked");
            int hoursWorked1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("how much is persons' 1 hourly rate?");
            int hourlyRate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPerson 2");
            Console.WriteLine("how many hours worked?");
            int hoursWorked2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("how much is persons' 2 hourly rate?");
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            
            int Salary1 = hoursWorked1 * hourlyRate1 * 52;
            
            Console.WriteLine("Persons' 1 Salary is " + Salary1);
            int Salary2 = hoursWorked2 * hourlyRate1 * 52;
            Console.WriteLine("Persons' 2 Salary is " + Salary2);
            Console.WriteLine("does person 1 make more than person 2?");
            bool trueOrFalse = Salary1 >= Salary2;
            Console.WriteLine(trueOrFalse);
            Console.ReadLine();
        }

    }
}


//Hey Myron,

//This is off to a good start but needs to be improved.

//The program user should be able to type in hours and wages for both people and then the program with output true or false if person 1 makes more money.

//Take some time to review the requirements and rewatch the videos I mentioned in the last feedback I gave you. They should clarify a lot for you.

//Let us know if you get stuck and need help.

//-Holden