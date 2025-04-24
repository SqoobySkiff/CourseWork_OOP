using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_OOP
{
    public class UserBasket
    {
        public List<LightCars> lightcars { get; set; } = new List<LightCars>();
        public List<SUV> suv { get; set; } = new List<SUV>();
    }

}
