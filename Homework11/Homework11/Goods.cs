using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    public class Goods
    {
        public int GoodsID { get; set; }
        public string GName { get; set; }
        public int GPrice { get; set; }
        public Goods()
        { }
        public Goods(int GoodsID,string GName,int GPrice)
        {
            this.GoodsID = GoodsID;
            this.GName = GName;
            this.GPrice = GPrice;
        }
        public override string ToString()
        {
            return $"商品id{GoodsID},商品{GName},价格{GPrice}";
        }
    }
}
