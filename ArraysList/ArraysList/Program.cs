using System;
using System.Collections.Generic;




    class Program
    {
        static void Main()
        {
        List<string> intList = new List<string>();
        intList.Add("Hiya");
        intList.Add("Dmy");
        intList.Remove("Dmy");

        Console.WriteLine(intList[0]);
        Console.ReadLine();




        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 10;
        //numArray[2] = 546;
        //numArray[3] = 1525;
        //numArray[4] = 2368;

        //int[] numArray1 = new int[] { 5, 10, 546, 1525, 2368 };

        //int[] numArray2 = { 2, 6, 1, 105, 4000, 400, 5600 };

        //numArray2[6] = 1400;
        //Console.WriteLine(numArray2[6]);
        //Console.ReadLine();
        }
    }

//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:

////1. Create a one-dimensional Array of strings.
//Ask the user to select an index of the Array and then display the string at that index on the screen.

//2. Create a one-dimensional Array of integers.
//Ask the user to select an index of the Array and then display the integer at that index on the screen.

//3. Add in a message that displays when the user selects an index that doesn’t exist.

//4. Create a List of strings.Ask the user to select an index of the List and then display the content at that index on the screen.