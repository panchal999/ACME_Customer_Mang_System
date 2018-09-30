using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderDisplay
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderDisplayItem> OrderDisplayItemList;
        public int OrderId { get; private set; }
        public Address ShippingAddress { get; set; }


    }
}
