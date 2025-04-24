using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_OOP
{
    public class SellerRequest
    {
        public int CarId { get; set; }  // ID of the car being requested
        public string RequestedBy { get; set; }  // Username of the person requesting the car
        public DateTime RequestDate { get; set; }  // Date and time when the request was made
    }
}
