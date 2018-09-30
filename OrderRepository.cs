using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderRepository
    {
        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();
            if(orderId==10)
            {
                orderDisplay.FirstName = "panchal";
                orderDisplay.LastName = "parth";
                var time = DateTime.Now;
                orderDisplay.OrderDate = new DateTimeOffset(time);
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "StreetLine2",
                    City = "gdh",
                    State = "Gujrat",
                    Country = "India",
                    PostalCode = "384001"
                };


            }
            orderDisplay.OrderDisplayItemList = new List<OrderDisplayItem>();
            if (orderId == 10)
            {
                var orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "toy",
                    PurchasePrice = 50,
                    OrderQuantity=2
                    
                };
                orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);
                 orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "toy",
                    PurchasePrice = 50,
                    OrderQuantity = 2

                };
                orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);
            }
            return orderDisplay;
           }
    }
}
