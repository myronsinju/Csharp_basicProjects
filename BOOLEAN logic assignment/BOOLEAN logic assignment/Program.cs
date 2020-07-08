using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOLEAN_logic_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int yourAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?");
            string yourAnswer = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int amountTickets = Convert.ToInt32(Console.ReadLine());

            int ageQualify = 15;
            int DUI = 0;
            int speedingTicket = 3;
                bool toQualify = (ageQualify >= 15 && DUI <= 0 && speedingTicket <= 3);
            Console.WriteLine(toQualify);


        }
    }
}



//Ask the following questions:

//What is your age?

//Have you ever had a DUI?

//How many speeding tickets do you have?

//Use the following qualification rules to determine if the applicant qualifies for car insurance:

//Applicants must be over 15 years old.

//Applicants must not have any DUI’s.

//Applicants must not have more than 3 speeding tickets.

//Print the result of the boolean expression created from the above business rules.

//EXAMPLE OUTPUT
//What is your age?
//32
//Have you ever had a DUI?
//false
//How many speeding tickets do you have?
//1
//Qualified?
//true
