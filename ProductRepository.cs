using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product();
            Object myObject = new Object();
            Console.WriteLine(myObject.ToString());
            Console.WriteLine(product.ToString());
            return product;
        }
        public bool Save(Product product)
        {
            var success = true;
            if(product.HasChanges && product.IsValid)
            {
                if(product.IsNew)
                {
                    //store to database
                }
                else
                {
                    //update product
                }
            }
            return success;
        }
    }
}
