using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatchsub2
{
    class ZeroException : Exception
    {
        public ZeroException() // creating the exception itself
           : base() { }
        public ZeroException(string message)
            : base(message) { }
    }
}
