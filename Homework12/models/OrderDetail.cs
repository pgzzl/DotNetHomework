using System;
namespace TodoApi.models
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int ODAmount { get; set; }
        public int GoodsID { get; set; }
        public OrderDetail() { }
        public OrderDetail(int id, int amount, int GoodsID)
        {
            this.OrderDetailID = id;
            this.ODAmount = amount;
            this.GoodsID = GoodsID;
        }
        public override string ToString()
        {
            return $"明细{OrderDetailID},数量{ODAmount},商品{GoodsID}";
        }
    }
}
