using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 4 ? "You have an awesomse fav number!" : "You have a different fav number than me";
            Console.WriteLine(result);
            
            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("Ugh.. something went wrong.");
            //}


            //int currentTemperature = 80;
            //int roomTemperature = 70;

            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp." : "It is not room temp.";   //ternary operator 

            //Console.WriteLine(comparisonResult);
            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("it is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("Room tempeature is warmer than current temperature");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature");
            //}
            Console.ReadLine();
        }
    }
}
