using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split();
            string serialNumber = input[0];
            

            List<Box> boxes = new List<Box>();

            while (serialNumber != "end")
            {
                string itemName = input[1];
                double itemQuantity = double.Parse(input[2]);
                double itemPrice = double.Parse(input[3]);

                boxes.Add(new Box(new Item(itemName,itemPrice),serialNumber,itemQuantity));

                input = Console.ReadLine().Split();
                serialNumber = input[0];
            }
            boxes = boxes.OrderByDescending(e => e.PriceForBox).ToList();
            foreach (var box in boxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:f2}");
            }
           
        }
    }
    class Item
    {
        public Item(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name { get; set; }
        public double Price { get; set; }
    }
    class Box
    {
        public Box(Item item, string serialNumber, double itemQuantity)
        {
            this.Item = item;
            this.SerialNumber = serialNumber;
            this.ItemQuantity = itemQuantity;
        }
        public Item Item { get; set; }
        public string SerialNumber { get; set; }
        public double ItemQuantity { get; set; }
        public double PriceForBox
        {
            get
            {
                return ItemQuantity * Item.Price;
            }

        }
    }
    
}
