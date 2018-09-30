using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.FirstName = "Parth";
            customer.LastName = "Panchal";

            string expected = "Parth Panchal";

            //-- Act
            string actual = customer.FullName;

            //-Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.LastName = "Panchal";

            string expected = "Panchal";

            //-- Act
            string actual = customer.FullName;

            //-Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.FirstName = "Parth";
          

            string expected = "Parth";

            //-- Act
            string actual = customer.FullName;

            //-Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //-- Arrange
            Customer customer = new Customer();

            customer.LastName = "Panchal";
            customer.EmailAddress = "parth.np5@gmail.com";
            var expected = true;

            //-- Act
            //var actual = customer.Validate();

            //-Assert
           // Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.EmailAddress = "parth.np5@gmail.com";
            var expected = false;

            //-- Act
         //   var actual = customer.Validate();

            //-Assert
         //   Assert.AreEqual(expected, actual);
        }

    }
}
