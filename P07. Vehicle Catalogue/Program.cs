using System;
using System.Collections.Generic;

namespace P07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] data = input.Split("/");

                string typeVehicle = data[0];
                string brandVehicle = data[1];
                string modelOfVehicle = data[2];
                int horseOfWeight = int.Parse(data[3]);

                if (typeVehicle == "Car")
                {
                    catalog.Cars.Add(new Car()
                    {
                        Brand = brandVehicle,
                        Model = modelOfVehicle,
                        HorsePower = horseOfWeight


                    }); 

                }
                else if (typeVehicle == "Truck")
                {
                    catalog.Trucks.Add(new Truck()
                        
                        
                        
                        
                        )
                }

            }

        }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }
    class Catalog
    {
        public List<Car> Cars { get; }
        public List<Truck> Trucks { get; }

        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
    
    }
}
