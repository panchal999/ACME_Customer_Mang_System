using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer :EntityBase,ILoggable
    {
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        public int CustomerType{ get; set; }
        public List<Address> AddressList { get; set; }


        public Customer():this(0)
        {

        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public static int InstanceCount { get; set; }
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
       
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName = " "+fullName;
                    }
                    fullName = FirstName+fullName;
                }
                return fullName;
            }
        }

        public override string ToString()
        {
            return FullName;
        }

        public string Log()
        {
            var logstring = this.CustomerId+" "+this.FullName+" "+this.EmailAddress+" status: "+this.EntityState.ToString() ;
            return logstring;
        }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
