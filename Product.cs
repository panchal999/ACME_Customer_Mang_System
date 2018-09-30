using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product: EntityBase,ILoggable
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            this.ProductId = productId;
        }

       
       
        public Decimal? CurrentPrice { get; set; }
        //public string ProductName { get; set; }
        private String _ProductName;

        public String ProductName
        {
            get {

                //return StringHandler.InsertSpaces(_ProductName) ;
                return _ProductName.InsertSpaces();
            }
            set { _ProductName = value; }
        }

        public string ProductDescription { get; set; }
        public int ProductId { get; set; }

        public override bool Validate()
        {
            var isvalid = true;
            if (string.IsNullOrWhiteSpace(ProductName))
                isvalid = false;
            if (CurrentPrice == null) isvalid = false;
                isvalid = false;
            return isvalid;
        }

        public override string ToString()
        {
            return ProductName;
        }
        public string Log()
        {
            var logstring = this.ProductId + " " + this.ProductName + " " + this.ProductDescription + " status: " + this.EntityState.ToString();
            return logstring;
        }

    }
}
