using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HodelManagement.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsPrimary { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
