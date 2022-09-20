using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 50, 60, 42, 74, 44, 100 };
            Console.WriteLine("Pick a number");



            try
            {
                int NumberGuessed = Convert.ToInt32(Console.ReadLine());
                foreach (int score in numbers)
                {
                    int Result = score / NumberGuessed;
                    Console.WriteLine(Result);
                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please Type a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please dont divide by Zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("The Program has emerged from the try/catch block");
            Console.ReadLine();
        }
    }
}
