using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Class1
    {
        public void divide(int firstNumber)
        {
            int result = firstNumber / 2;
            Console.WriteLine(result);


        }
        public int example(int example2, out int example3)
        {
            example3 = example2 + 5;
            return example3;
        }
        public int example(int example2)
        {
            int result = example2 + 8;
            return result;
        }
    }
}
