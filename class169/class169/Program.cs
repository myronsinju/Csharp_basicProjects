using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class169
{
    class Program
    {
        static void Main(string[] args)
        {
            aMethod aMethod = new aMethod();
            Console.WriteLine("lets divide a number by two");
            int input = Convert.ToInt32(Console.ReadLine());
            aMethod.div2(input, out int result);

            Console.WriteLine("your number divided by two is... " + result);

            Console.WriteLine("lets divide a number by two");
            double input2 = Convert.ToDouble(Console.ReadLine());
            aMethod.div2(input2, out double answer);

            Console.WriteLine("your number divided by two is... " + answer);
            Console.WriteLine(staticClass.example());
            Console.ReadLine();
        }
    }
}
//1. Create a class. In that class, create a void method that outputs an integer.Have
//    the method divide the data passed to it by 2.
//2. In the Main() method, instantiate that class.
//3. Have the user enter a number.Call the method on that number.Display the output to the screen.
//   It should be the entered number, divided by two.
//4. Create a method with output parameters.
//5. Overload a method.
//6. Declare a class to be static



//static int PlusMethodInt(int x, int y)
//{
//    return x + y;
//}

//static double PlusMethodDouble(double x, double y)
//{
//    return x + y;
//}

