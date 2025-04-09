using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_OOP
{
    public class ListOfUsers
    {
        public List<Seller> Sellers { get; set; } = new List<Seller>();
        public List<Customer> Customers { get; set; } = new List<Customer>();
    }
}
