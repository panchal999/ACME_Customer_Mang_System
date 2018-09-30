using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            ProductRepository productRepository = new ProductRepository();
            Product product=productRepository.Retrieve(1);
            p
        }
    }
}
