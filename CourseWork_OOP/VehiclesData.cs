using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_OOP
{
    public class VehiclesData
    {
        public List<LightCars> lightcars { get; set; }
        public List<SUV> suv { get; set; }
        public List<Sportcar> sportcars { get; set; }
        public List<Pickup> pickups { get; set; }

        public List<BaseCar> CombineCars()
        {
            List<BaseCar> allCars = new List<BaseCar>();
            foreach (var car in lightcars)
            {
                allCars.Add(car);
            }
            foreach (var car in suv)
            {
                allCars.Add(car);
            }
            foreach (var car in pickups)
            {
                allCars.Add(car);
            }
            foreach (var car in sportcars)
            {
                allCars.Add(car);
            }
            return allCars;
        }
    }
}
