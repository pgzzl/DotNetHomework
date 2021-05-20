using System;
namespace TodoApi.models
{
    public class Goods
    {
        public int GoodsID { get; set; }
        public string GName { get; set; }
        public int GPrice { get; set; }
        public Goods()
        { }
        public Goods(int GoodsID, string GName, int GPrice)
        {
            this.GoodsID = GoodsID;
            this.GName = GName;
            this.GPrice = GPrice;
        }
        public override string ToString()
        {
            return this.GName;
        }
        
    }
}
