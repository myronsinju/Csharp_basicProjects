using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick another number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("dividing the two numbers...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }
            catch(FormatException)
            {
                Console.WriteLine("please type a whole number");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Anything divided by 0 is itself");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            
        }   
    }
}
