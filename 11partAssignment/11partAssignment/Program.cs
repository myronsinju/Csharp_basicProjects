using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11partAssignment
{
    class Program
    {
        static void Main(string[] args) 
        {

            //CONSOLE APP ASSIGNMENT PART ONE
            //In a console app, do the following:
            //Create a one-dimensional Array of strings.
            //Ask the user to input some text.
            //Create a loop that goes through each string in the Array, adding the user’s text to the string.
            //Then create a loop that prints off each string in the Array on a separate line.
            //Save and execute your code.

            string[] stringArray = new string[7];
            Console.WriteLine("input a text about the Array");
            stringArray[0] = "one";
            stringArray[1] = "two";
            stringArray[2] = "three";
            stringArray[3] = "four";
            stringArray[4] = "five";
            stringArray[5] = "six";
            stringArray[6] = "seven";

            Console.WriteLine("please input some text");
            string userInput = Console.ReadLine();

            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i] +" " + userInput);
            }
            

            //CONSOLE APP ASSIGNMENT PART TWO
            //Inside your console app, do the following:
            //Create an infinite loop.
            //Save your code.

            //for (int i = 0; i < 5; i--)
            //{
            //    Console.WriteLine("Howdy");
            //}

            //CONSOLE APP ASSIGNMENT PART THREE
            //Inside your console app, do the following:
            //Fix the infinite loop so it will execute.
            //Save and execute your code.

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Howdy");
            }

            //    CONSOLE APP ASSIGNMENT PART FOUR
            //Inside your console app, do the following:
            //Create a loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
            //Save and execute your code.

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Whats up buttercup!");
            }

            //CONSOLE APP ASSIGNMENT PART FIVE
            //Inside your console app, do the following:
            //Create a loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
            //Save and execute your code.


            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("how's the day?");
            }

            //CONSOLE APP ASSIGNMENT PART SIX
            //Inside your console app, do the following:
            //Create a List of strings where each item in the list is unique.Ask the user to input text to search 
            //for in the List.Create a loop that iterates through the loop and then displays the index of the array that 
            //contains matching text on the screen.
            //Save and execute your code.

            //CONSOLE APP ASSIGNMENT PART SEVEN
            //Inside your console app, do the following:
            //Add code to that above loop that tells a user if they put in text that isn’t in the List.
            //Save and execute your code.

            //CONSOLE APP ASSIGNMENT PART EIGHT
            //Inside your console app, do the following:
            //Add code to that above loop that stops it from executing once a match has been found.
            //Save and execute your code.

            List<string> shoes = new List<string>()
            {
                "Vans", "Crocs", "Nike's", "Jordan's", "tennis shoes"
            };
            Console.WriteLine("type in a shoe");
            string shoeAnswer = Console.ReadLine();
            if (shoes.Contains(shoeAnswer))
            {
                for (int i = 0; i < shoes.Count; i++)
                {
                    if (shoes[i] == shoeAnswer)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("not in the list");
            }

            //CONSOLE APP ASSIGNMENT PART NINE
            //Inside your console app, do the following:
            //Create a List of strings that has at least two identical strings in the List.
            //Ask the user to select text to search for in the List. 
            //Create a loop that iterates through the loop and then displays the indices of the array that 
            //contain matching text on the screen.
            //Save and execute your code.

            //CONSOLE APP ASSIGNMENT PART TEN
            //Inside your console app, do the following:
            //Add code to that above loop that tells a user if they put in text that isn’t in the List.
            //Save and execute your code.


            List<string> trucks = new List<string>()
            {
                "Tundra", "F-150", "Tundra", "Silverado", "Sierra"
            };
            Console.WriteLine("type in a truck");
            string truckAnswer = Console.ReadLine();
            if (trucks.Contains(truckAnswer))
            {
                for (int i = 0; i < trucks.Count; i++)
                {
                    if (trucks[i] == truckAnswer)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("not in the list");
            }


            //CONSOLE APP ASSIGNMENT PART ELEVEN
            //Inside your console app, do the following:
            //Create a List of strings that has at least two identical strings in the List.
            //Create a foreach loop that evaluates each item in the list, 
            //and displays a message showing the string and whether or not it has already appeared in the list.
            //Save and execute your code.

            List<string> food = new List<string>()
            {
                "french fries", "Salmon", "Avocado", "sphagetti", "ramen", "pickles", "cheese", "tacos", "macaroni & cheese",
                "french fries", "ribs", "enchilidas", "candy bars", "sweet potatoe fries"
            };

            List<string> foodTwo = new List<string>();
            
            foreach(string item in food)
            {
                if(!foodTwo.Contains(item))
                {
                    Console.WriteLine(item + " sounds tasty right now!");
                    foodTwo.Add(item);
                }
                else
                {
                    Console.WriteLine(item + " this item has been mentioned already");
                }
                
            }
             Console.ReadLine();
        }
    }
}