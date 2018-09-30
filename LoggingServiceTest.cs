using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;
using System.Collections.Generic;
using ACM.BL;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAddress = "parth.np5@gmail.com",
                FirstName = "Panchal",
                LastName = "Parth",
            };
            changedItems.Add(customer as ILoggable);

            var product = new Product(2)
            {
                ProductName = "toy",
                ProductDescription = "toy",
                CurrentPrice = 6M
            };
            changedItems.Add(product as ILoggable);
            LoggingService.WriteToFile(changedItems);
        }
           
     }
    
}
