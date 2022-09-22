using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_method_submission
{
    class Class1
    {
        public int Multiplication(int Number1)
        {

            int result = Number1 * 4;
            return result;
        }
        public int Multiplication(decimal Number2)
        {
            int result = Convert.ToInt32(Number2) * 5;
            return result;
        }
        public int Muliplication(string Number3)
        {
            int result = Convert.ToInt32(Number3) * 6;
            return result;
        }
    }
}
