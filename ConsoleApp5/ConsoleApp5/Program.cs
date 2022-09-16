using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        { //must define length before you start the array
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

            List<string> intList = new List<string>();
            intList.Add("Hello");
            intList.Add("Jesse");
            intList.Remove("Jesse");

            Console.WriteLine(intList[0]);
            Console.ReadLine();

          //import photos byte[] byteArray = new byte[5000];
        }
    }
}
`