using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_OOP
{
    public abstract class BaseCar
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public string Condition { get; set; }
        public string Country { get; set; }
        public string ImagePath { get; set; } 
        public string Description { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public Image Image { get; set; } 
    }
}
