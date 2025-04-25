using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_OOP
{
    public class SellerRequest
    {
        public int CarId { get; set; }  
        public string RequestedBy { get; set; }  
        public string Email { get; set; }
        public DateTime RequestDate { get; set; }  
    }
}
