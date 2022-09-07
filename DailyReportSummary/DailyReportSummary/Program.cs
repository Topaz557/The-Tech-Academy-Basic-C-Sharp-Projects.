using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportSummary
{
    class Program
    {
        static void Main(string[] args)
        {
            //comment
            Console.WriteLine("The Tech Academy");
            Console.ReadLine();
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();
            // asks what your name is
            Console.WriteLine("What is your name?");
            // sets your answer to variable yourName
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            // writes what your name is
            // asks the course
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            //turns the string yourCourse into a variable
            Console.WriteLine("You are on course: " + yourCourse);
            // returns the course
            // asks what page you are on
            Console.WriteLine("What page number?");
            int yourPage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your page number is: " + yourPage);
            // asks if you need help with anything, second line converts to a bool
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”?");
            bool help = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(help);
            //asks question, converts your answer to a variable assinged as yourAnswer
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string yourAnswer = Console.ReadLine();
            Console.WriteLine(yourAnswer);
            //asks if you have any other feedback, second line converts the string answer inyo yourAnswer2
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string yourAnswer2 = Console.ReadLine();
            Console.WriteLine(yourAnswer2);

            Console.WriteLine("How many hours did you study today?");
            int yourHours = Convert.ToInt32(Console.ReadLine());

            //displays all answers in an orgnaized fashion
            Console.WriteLine(yourName + "\n" + yourCourse + "\n" + yourPage + "\n" + help + "\n" + yourAnswer + "\n" + yourAnswer2 + "\n" + yourHours);
            Console.WriteLine("“Thank you for your answers. An Instructor will respond to this shortly. Have a great day!”");
            Console.ReadLine();
        }
    }
}
