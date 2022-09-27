using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Employee<T> // t makes it generic
    {
        public List<T> things { get; set; }
      
    }
}
