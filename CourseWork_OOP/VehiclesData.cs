using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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

            if (lightcars != null)
            {
                allCars.AddRange(lightcars);
            }
            if (suv != null)
            {
                allCars.AddRange(suv);
            }
            if (sportcars != null)
            {
                allCars.AddRange(sportcars);
            }
            if (pickups != null)
            {
                allCars.AddRange(pickups);
            }

            return allCars;
        }

        public List<BaseCar> FindByID(int id)
        {
            List<BaseCar> idCars = new List<BaseCar>();
            foreach (var car in lightcars)
            {
                if (car.ID == id)
                idCars.Add(car);
            }
            foreach (var car in suv)
            {
                if (car.ID == id)
                    idCars.Add(car);
            }
            foreach (var car in pickups)
            {
                if (car.ID == id)
                    idCars.Add(car);
            }
            foreach (var car in sportcars)
            {
                if (car.ID == id)
                    idCars.Add(car);
            }
            return idCars;
        }

        public void AddCarToCollection(BaseCar newCar)
        {
            if (newCar is LightCars lightCar)
            {
                lightcars.Add(lightCar);
            }
            else if (newCar is SUV suvCar)
            {
                suv.Add(suvCar);
            }
            else if (newCar is Sportcar sportCar)
            {
                sportcars.Add(sportCar);
            }
            else if (newCar is Pickup pickupCar)
            {
                pickups.Add(pickupCar);
            }
        }

        public bool UpdateCarInList<T>(T car, List<T> cars) where T : BaseCar
        {
            var carToUpdate = cars.FirstOrDefault(c => c.ID == car.ID);
            if (carToUpdate != null)
            {
                carToUpdate.Color = car.Color;
                carToUpdate.Description = car.Description;
                carToUpdate.HP = car.HP;
                carToUpdate.Make = car.Make;
                carToUpdate.Model = car.Model;
                carToUpdate.Price = car.Price;
                carToUpdate.Year = car.Year;
                carToUpdate.Condition = car.Condition;
                carToUpdate.Country = car.Country;
                carToUpdate.Gear = car.Gear;
                carToUpdate.ImagePath = car.ImagePath;
                return true;
            }
            return false;
        }
        public bool UpdateLightCar(LightCars car)
        {
            return UpdateCarInList(car, lightcars);
        }

        public bool UpdateSUV(SUV car)
        {
            return UpdateCarInList(car, suv);
        }

        public bool UpdateSportcar(Sportcar car)
        {
            return UpdateCarInList(car, sportcars);
        }

        public bool UpdatePickup(Pickup car)
        {
            return UpdateCarInList(car, pickups);
        }

        public bool ModifyCarInBasket(int carId)
        {
            bool modified = false;

            foreach (var car in lightcars) { if (car.ID == carId) { car.ID = 222222; modified = true; } }
            foreach (var car in suv) { if (car.ID == carId) { car.ID = 222222; modified = true; } }
            foreach (var car in sportcars) { if (car.ID == carId) { car.ID = 222222; modified = true; } }
            foreach (var car in pickups) { if (car.ID == carId) { car.ID = 222222; modified = true; } }

            return modified;
        }
        public void RemoveCarFromCollection(int carId)
        {
            lightcars.RemoveAll(c => c.ID == carId);
            suv.RemoveAll(c => c.ID == carId);
            sportcars.RemoveAll(c => c.ID == carId);
            pickups.RemoveAll(c => c.ID == carId);
        }

        public List<int> GetAllCarIDs()
        {
            List<int> allCarIDs = new List<int>();

            allCarIDs.AddRange(lightcars.Select(car => car.ID));
            allCarIDs.AddRange(suv.Select(car => car.ID));
            allCarIDs.AddRange(sportcars.Select(car => car.ID));
            allCarIDs.AddRange(pickups.Select(car => car.ID));

            return allCarIDs;
        }

    }
}
