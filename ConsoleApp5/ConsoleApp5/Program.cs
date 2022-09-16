using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        { //must define length before you start the array REMOVE STRING ARGS FOR ALL STRING?ARRAY work
          //int[] numArray = new int[5];
          //numArray[0] = 5;
          //numArray[1] = 2;
          //numArray[2] = 10;
          //numArray[3] = 200;
          //numArray[4] = 5000;

            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

            //int[] numArray2 = {  5, 2, 10, 200, 5000, 600, 2400};
            //Console.WriteLine(numArray2[3]);
            //Console.ReadLine();

            //List<string> intList = new List<string>();
            //intList.Add("Hello");
            //intList.Add("Jesse");
            //intList.Remove("Jesse");

            //Console.WriteLine(intList[0]);
            //Console.ReadLine();

            //import photos byte[] byteArray = new byte[5000];




            //Itterations ADD IN STRING [] ARGS
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testScores.Length; i++) 
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();


            //string[] names = { "Jesse", "Eric", "Daniel", "Adam" };

            //for (int j = 0; j < names.Length; j++) 

            //    {
            //        Console.WriteLine(names[j]);
            //    }

            //Console.ReadLine();

            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing Test Score:" + score);
            //    }
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            //foreach (string name in names)
            //{
            //    //if (name == "Jesse") remove comments to target name
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            //Console.ReadLine();

            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99};
            List<int> passingScores = new List<int>();
            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
            
        
        }
    }
}
