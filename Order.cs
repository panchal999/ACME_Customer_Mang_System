using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public int CustomerId { get; private set; }
        public int ShippingAddressId { get; set; }
        public List<OrderItem> orderItems { get; set; }

        public Order()
        {

        }
        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public Order Retrieve(int orderId)
        {
            return new Order();
        }
        public bool Save()
        {
            return true;
        }

      
        public bool Validate()
        {
            var isvalid = true;
            if (OrderDate == null)
                isvalid = false;
            
            return isvalid;
        }

        public override string ToString()
        {
            return OrderDate.Value.Date+" orderid="+OrderId;
        }
    }
}
