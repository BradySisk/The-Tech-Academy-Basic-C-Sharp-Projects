using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Employee2 <T>
    {

        public List<T> things { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int ID { get; set; }
    }
}
