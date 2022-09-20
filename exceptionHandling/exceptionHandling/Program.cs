using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a number");
                int NumberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two");
                int numberthree = NumberOne / numberTwo;
                Console.WriteLine(NumberOne + "Divided by" + numberTwo + "equals" + numberthree);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please Type a whole number.");
                return;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Please dont divide by Zero");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            
            Console.ReadLine();
        }
    }
}
