using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatchsub2
{
    public class NegativeException : Exception
    {
        public NegativeException() // creating the exception itself
            : base() { }
        public NegativeException(string message)
            : base(message) { }

    }
}
