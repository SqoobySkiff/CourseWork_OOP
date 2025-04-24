using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_OOP
{
    public class UserBasket
    {
        public List<BasketItem> lightcars { get; set; } = new List<BasketItem>();
        public List<BasketItem> suv { get; set; } = new List<BasketItem>();
    }

}
