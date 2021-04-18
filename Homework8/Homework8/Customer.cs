using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    //客户类：名字
    public class Customer
    {
        public string Name { get; set; }
        public Customer()
        { }
        public Customer(string name)
        {
            this.Name = name;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
