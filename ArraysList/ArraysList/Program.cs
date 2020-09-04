using System;
using System.Collections.Generic;




    class Program
    {
        static void Main()
        {
        try
        {
            Console.WriteLine("hello user please input a value between 0-4");



            string[] arrayString = new string[5];
            arrayString[0] = "HIYA";
            arrayString[1] = "Dmy";
            arrayString[2] = "ok";
            arrayString[3] = "howdy!";
            arrayString[4] = "silverman!";


            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(arrayString[userInput]);



            Console.WriteLine("hello user please insert another value between 0-4");
            int[] numArray = new int[5];
            numArray[0] = 5;
            numArray[1] = 10;
            numArray[2] = 546;
            numArray[3] = 1525;
            numArray[4] = 2368;

            int userSelected = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numArray[userSelected]);
        }
        catch
        {
            Console.WriteLine("Please insert a value between 0-4 only");
        }
        List<string> stringList = new List<string>();
        stringList.Add("whatsup!");
        stringList.Add("buttercup!");
        stringList.Add("what's");
        stringList.Add("cooking");
        stringList.Add("good lookin");

        Console.WriteLine("Hello user pick another number yet again between 0-4");
        int userEntered = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(stringList[userEntered]);
        Console.ReadLine();
        }
    }

//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:

////1. Create a one-dimensional Array of strings.
//Ask the user to select an index of the Array and then display the string at that index on the screen.

//2. Create a one-dimensional Array of integers.
//Ask the user to select an index of the Array and then display the integer at that index on the screen.

//3. Add in a message that displays when the user selects an index that doesn’t exist.

//4. Create a List of strings.Ask the user to select an index of the List and then display the content at that index on the screen.