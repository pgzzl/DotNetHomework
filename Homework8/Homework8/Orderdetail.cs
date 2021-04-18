using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    //订单明细类:具体商品,商品数量，,总价
    public class Orderdetail
    {
        public Goods Goods { get; set; }
        public int Number { get; set; }
        public int Amount { get => Number * Goods.Price; }
        public Orderdetail()
        { }
        public Orderdetail(Goods goods, int num)
        {
            Goods = goods;
            Number = num;
        }
        public override bool Equals(object obj)
        {
            var s = obj as Orderdetail;
            return s != null && EqualityComparer<Goods>.Default.Equals(Goods, s.Goods);
        }
        public override int GetHashCode()
        {
            return 3443982 + EqualityComparer<Goods>.Default.GetHashCode(Goods);
        }


        public override string ToString()
        {
            return $"商品：{Goods}数量 {Number}";
        }
    }
}
