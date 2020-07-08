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
            Console.WriteLine("40");
            Console.WriteLine("how much is person's 1 hourly rate?");
            Console.WriteLine("\n85");
            Console.WriteLine("\nPerson 2");
            Console.WriteLine("how many hours worked?");
            Console.WriteLine("38");
            Console.WriteLine("hourly salary of persons 2?");
            Console.WriteLine("45");
            Console.WriteLine("what is the annual salary of persons 1?");
            Console.WriteLine("\n163,000");
            Console.WriteLine("what is the annual salary of persons 2?");
            Console.WriteLine("82,080");
            Console.WriteLine("does person 1 make more than person 2?");
            bool trueOrFalse = 163000 >= 82080;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();
        }

    }
}
