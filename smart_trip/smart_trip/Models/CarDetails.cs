using System;
using System.Collections.Generic;
using System.Text;

namespace smart_trip.Models
{
    public class CarDetails
    {
        public int Id { get; set; }
        public CarModel CardModel { get; set; }    
    }

    public class CarManufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; } 
        //public byte[] Icon { get; set; }
    }

    public class CarModel
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; } 
        public CarManufacturer CarManufacturer { get; set; }
        public DateTime LaunchDate { get; set; }
        public bool IsDiscontinued { get; set;}
        public CarMake CarMake { get; set; }
    }

    public enum CarMake
    {
        Hatchback,
        Sedan,
        SUV,
        Truck
    }
}
