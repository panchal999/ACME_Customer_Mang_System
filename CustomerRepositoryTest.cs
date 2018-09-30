using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System.Collections.Generic;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrivingExiting()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "parth.np5@gmail.com",
                FirstName = "Panchal",
                LastName = "Parth",
                AddressList=new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Bag End",
                        StreetLine2 = "StreetLine2",
                        City = "gdh",
                        State = "Gujrat",
                        Country = "India",
                        PostalCode = "384001"
                    },
                     new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Bag End",
                        StreetLine2 = "StreetLine2",
                        City = "gdh",
                        State = "Gujrat",
                        Country = "India",
                        PostalCode = "384001"
                    }

                }

            };

            var actual = customerRepository.Retrieve(1);

            //Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress); 
            
            for(int i=0;i<1;i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
            }     
        }
    }
}
