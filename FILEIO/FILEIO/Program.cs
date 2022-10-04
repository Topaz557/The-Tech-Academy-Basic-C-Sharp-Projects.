using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FILEIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("What is a number?");
            int card = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DateTime.Now.AddHours(card));// here we are using the opperation add hours, this allows us to add the variable to the datetime, we then specify in () that the variable is card. 
           
            //using (StreamWriter file = new StreamWriter(@"C:\Users\andre\Documents\GitHub\parseText\SampleParse1.txt", true))// takes in a bath from stream writer, then asks us to append (true), reference to file below, then write the card 
            //{
               
            //    file.WriteLine(card);
            //}
            Console.WriteLine(card);
            Console.ReadLine();
        }
    }
}
