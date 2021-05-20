using System;
namespace TodoApi.models
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
