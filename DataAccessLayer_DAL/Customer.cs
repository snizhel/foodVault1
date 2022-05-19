using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public class Customer
    {
        //properties
        public int CustomerId { get; set; }
        public string DisplayNameCustomer { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int MoreInfo { get; set; }
        public DateTime ContactDate { get; set; }

        //constructor
        public Customer() { }
    }
}
