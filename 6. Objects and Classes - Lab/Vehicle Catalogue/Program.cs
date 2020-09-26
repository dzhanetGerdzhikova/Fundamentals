using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('/');

            List<Truck> trucksCatalogue = new List<Truck>();
            List<Car> carsCatalogue = new List<Car>();

            while(input[0]!="end")
            {
                if(input[0]=="Car")
                {
                    carsCatalogue.Add(new Car(input[1],input[2],int.Parse(input[3])));
                }
                else if(input[0]=="Truck")
                {
                    trucksCatalogue.Add(new Truck(input[1], input[2], int.Parse(input[3])));
                }


                input = Console.ReadLine().Split('/');
                
            }

            List<Car> orderedCars = carsCatalogue.OrderBy(e=>e.Brand).ToList();
            List<Truck> orderedTrucks = trucksCatalogue.OrderBy(e=>e.Brand).ToList();

            Console.WriteLine("Cars:");
            foreach (var car in orderedCars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
            Console.WriteLine("Trucks:");
            foreach (var truck in orderedTrucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
    class Truck
    {
        public Truck(string brand, string model, int weidht)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weidht;

        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

    }
    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;

        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    } 
    class Catalog
    {
        public string CollectionOfTrucks { get; set; }
        public string CollectionOfCars { get; set; }

    }
}
