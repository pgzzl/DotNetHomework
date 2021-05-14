using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public override string ToString()
        {
            return this.CustomerID;
         }       
    }
}
