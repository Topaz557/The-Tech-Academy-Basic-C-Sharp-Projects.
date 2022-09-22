using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            MathMethods deck = new MathMethods(); 
            Console.WriteLine("what number do you want to do the math operations on?");
            int math = Convert.ToInt32(Console.ReadLine()); // converting math to int to allow operations to be done

            int math2 = deck.Multiplication(math);// Here we are creating variable math 2, passing it deck (variable created to call class)
                                                  // Multiplication is the method name we used to cite already definined operation from MathMethods.cs
            Console.WriteLine(math2);


            int math3 = deck.Division(math);
            Console.WriteLine(math3);

            int math4 = deck.Subtraction(math);
            Console.WriteLine(math4);
            Console.ReadLine();
        }

        
    }
}
