using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<Vehicle> vehicles = new List<Vehicle>();

            while (input[0] != "End")
            {
                string type = input[0];
                string model = input[1];
                string color = input[2];
                double power = double.Parse(input[3]);
                vehicles.Add(new Vehicle(type, model, color, power));
                input = Console.ReadLine().Split(' ');
            }

            string modelVehicle = Console.ReadLine();

            while (modelVehicle != "Close the Catalogue")
            {
                Vehicle sortByModel = vehicles.Where(e => e.Model == modelVehicle).First();

                Console.WriteLine($"Type: {FirstLetterToUpperCaseOrConvertNullToEmptyString(sortByModel.Type)}");
                Console.WriteLine($"Model: {sortByModel.Model}");
                Console.WriteLine($"Color: {sortByModel.Color}");
                Console.WriteLine($"Horsepower: {sortByModel.Power}");

                modelVehicle = Console.ReadLine();
            }
            List<Vehicle> totaltrucks = vehicles.Where(e => e.Type == "truck").ToList();
            List<Vehicle> totalcars = vehicles.Where(e => e.Type == "car").ToList();

            double averageCarHP = CalculateVehicleAverageHP(totalcars);
            double averageTruckHP = CalculateVehicleAverageHP(totaltrucks);

            Console.WriteLine($"Cars have average horsepower of: {averageCarHP:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckHP:f2}.");
        }

        public static double CalculateVehicleAverageHP(List<Vehicle> vehicles)
        {
            if (vehicles.Count == 0)
            {
                return 0;
            }
            double averageCarHP = 0;
            foreach (var x in vehicles)
            {
                averageCarHP += x.Power;
            }
            return averageCarHP / vehicles.Count();
        }

        public static string FirstLetterToUpperCaseOrConvertNullToEmptyString(string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
    }

    internal class Vehicle
    {
        public Vehicle(string type, string model, string color, double power)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.Power = power;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Power { get; set; }
    }
}