using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);
            return address;
        }

        public bool Save()
        {
            return true;
        }
         public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "StreetLine2",
                City = "gdh",
                State = "Gujrat",
                Country = "India",
                PostalCode = "384001"
            };
            addressList.Add(address);
            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Bag End",
                StreetLine2 = "StreetLine2",
                City = "gdh",
                State = "Gujrat",
                Country = "India",
                PostalCode = "384001"
            };
            addressList.Add(address);
            return addressList;
        }
    }
}
