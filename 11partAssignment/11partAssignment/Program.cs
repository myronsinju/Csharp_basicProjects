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
            string[] stringArray = new string[7];
            Console.WriteLine("input a text about the Array");
            stringArray[0] = "one";
            stringArray[1] = "two";
            stringArray[2] = "three";
            stringArray[3] = "four";
            stringArray[4] = "five";
            stringArray[5] = "six";
            stringArray[6] = "seven";

            foreach (string s in stringArray)
            {
                Console.WriteLine(s);
            }

            for (int i = 0; i < 50; i--)
            {
                //string s = stringArray[i];
                Console.WriteLine();
            }

            Console.WriteLine("Guess a number??");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 8;
            do
            {
                switch (number)
                {
                    case 3:
                        Console.WriteLine("You guessed 3. Try again");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You guessed 7, Try again");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 87:
                        Console.WriteLine("you guessed 87, Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("you guessed 8. That is Correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("you're wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isGuessed);
            Console.WriteLine("what is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 4 ? "You have an awesomse fav number!" : "You have a different fav number than me";
            Console.WriteLine(result);

            int roomTemperature = 70;

            Console.WriteLine("Hi, what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            int currentTemperature = Convert.ToInt32(Console.ReadLine());
             

            if (currentTemperature == roomTemperature)
            {
                Console.WriteLine("It is exactly room temperature.");
            }
            else if (currentTemperature > roomTemperature)
            {
                Console.WriteLine("It is warmer than room temperature");
            }
            else if (roomTemperature > currentTemperature)
            {
                Console.WriteLine("It is colder than room temperature.");
            }
            else
            {
                Console.WriteLine("Ugh.. something went wrong.");
            }

            var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
            int count = 0;
            foreach (int element in fibNumbers)
            {
                count++;
                Console.WriteLine($"Element #{count}: {element}");
            }
            Console.WriteLine($"Number of elements: {count}");

            Console.Read();
            Console.ReadLine();
        }   
    }
}











//CONSOLE APP ASSIGNMENT PART ONE
//In a console app, do the following:

//Create a one-dimensional Array of strings.

//Ask the user to input some text.

//Create a loop that goes through each string in the Array, adding the user’s text to the string.

//Then create a loop that prints off each string in the Array on a separate line.

//Save and execute your code.



//CONSOLE APP ASSIGNMENT PART TWO
//Inside your console app, do the following:

//Create an infinite loop.

//Save your code.




//CONSOLE APP ASSIGNMENT PART THREE
//Inside your console app, do the following:

//Fix the infinite loop so it will execute.

//Save and execute your code.





//    CONSOLE APP ASSIGNMENT PART FOUR
//Inside your console app, do the following:

//Create a loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.

//Save and execute your code.




//CONSOLE APP ASSIGNMENT PART FIVE
//Inside your console app, do the following:

//Create a loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.

//Save and execute your code.



//CONSOLE APP ASSIGNMENT PART SIX
//Inside your console app, do the following:

//Create a List of strings where each item in the list is unique.Ask the user to input text to search for in the List.Create a loop that iterates through the loop and then displays the index of the array that contains matching text on the screen.


//Save and execute your code.





//CONSOLE APP ASSIGNMENT PART SEVEN
//Inside your console app, do the following:

//Add code to that above loop that tells a user if they put in text that isn’t in the List.

//Save and execute your code.





//CONSOLE APP ASSIGNMENT PART EIGHT
//Inside your console app, do the following:

//Add code to that above loop that stops it from executing once a match has been found.

//Save and execute your code.




//CONSOLE APP ASSIGNMENT PART NINE
//Inside your console app, do the following:

//Create a List of strings that has at least two identical strings in the List.Ask the user to select text to search for in the List. 
//Create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen.

//Save and execute your code.



//CONSOLE APP ASSIGNMENT PART TEN
//Inside your console app, do the following:

//Add code to that above loop that tells a user if they put in text that isn’t in the List.

//Save and execute your code.



//CONSOLE APP ASSIGNMENT PART ELEVEN
//Inside your console app, do the following:

//Create a List of strings that has at least two identical strings in the List.
//Create a foreach loop that evaluates each item in the list, 
//    and displays a message showing the string and whether or not it has already appeared in the list.

//Save and execute your code.