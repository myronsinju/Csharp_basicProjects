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

            Console.WriteLine("now please enter your packages height");
            int packHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("now please enter your packages width");
            int packWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("now please enter your packages length");
            int packLength = Convert.ToInt32(Console.ReadLine());

            

            if (packWeight > 50)
            {
                Console.WriteLine("This package is too heavy to be shipped by Package Express");
            }
            
            if (packWidth > 50)
            {
                Console.WriteLine("Package is too wide to be shipped by Package Express");
            }
            if (packHeight > 50)
            {
                Console.WriteLine("Package too Big to be shipped via Package Express");
            }
            if (packLength > 50)
            {
                Console.WriteLine("Package is too long to be shipped via Package Express");
            }
            int total = packHeight * packLength * packWidth;
            int otherTotal = packWeight;
            int combine = total * otherTotal;
            Console.WriteLine(combine);
           
            int quotient = combine / 100;
            Console.WriteLine("your estimated total for shipping is");
            Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

        }
    }
}

