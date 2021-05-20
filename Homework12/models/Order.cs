using System;
using System.Collections.Generic;

namespace TodoApi.models
{
    public class Order
    {

        public int OrderID { get; set; }
        public Customer Customer { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

    }
}
