using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        public Order Retrieve(int orderId)
        {
            return new Order();
        }
        public bool Save()
        {
            return true;
        }

        public Decimal? PurchasePrice { get; set; }
        public int OrderItemId { get; private set; }
        public int OrderQuantity { get;  set; }
        public int ProductId { get; set; }

        public bool Validate()
        {
            var isvalid = true;
            if (OrderQuantity <= 0) isvalid = false;
            if (ProductId <= 0) isvalid = false;
            if (PurchasePrice == null) isvalid = false;
            

            return isvalid;
        }
    }
}
