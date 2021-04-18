using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    //商品：商品名，单价
    public class Goods
    {
        private string name;
        private int price;
        public Goods()
        { }
        public Goods(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public string Name { get => name; }
        public int Price { get => price; }
        public override string ToString()
        {
            return $"{Name},价格{price}";
        }
    }
    

  
    
    
}
