using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branching_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to the Package Express, please follow the instructions below");

            Console.WriteLine("please enter your package's weight");
            int packWeight = Convert.ToInt32(Console.ReadLine());
            if (packWeight > 50)
            {
                Console.WriteLine("This package is too heavy to be shipped by Package Express");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("now please enter your packages height");
            int packHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("now please enter your packages width");
            int packWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("now please enter your packages length");
            int packLength = Convert.ToInt32(Console.ReadLine());

            

            
            
            if (packWidth + packHeight + packLength > 50)
            {
                Console.WriteLine("Package is too big to be shipped by Package Express");
                Console.ReadLine();
                Environment.Exit(0);
            }
           
            int total = (packHeight * packLength * packWidth * packWeight) / 100;
            decimal moneyValue = (decimal)total;
            
         
           
            
            Console.WriteLine("your estimated total for shipping is " + string.Format("{0:C}", moneyValue));
            Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

        }
    }
}

//decimal decimalMoneyValue = 1921.39m;
//string formattedMoneyValue = String.Format("{0:C}", decimalMoneyValue);