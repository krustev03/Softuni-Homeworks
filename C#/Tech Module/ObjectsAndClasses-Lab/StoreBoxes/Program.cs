using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            List<decimal> sorted = new List<decimal>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] parts = command.Split().ToArray();
                int serialNumber = int.Parse(parts[0]);
                string itemName = parts[1];
                int itemQuantity = int.Parse(parts[2]);
                decimal itemPrice = decimal.Parse(parts[3]);
                Box box = new Box();
                box.Item = new Item();
                box.Item.Name = itemName;
                box.Item.Price = itemPrice;
                box.Quantity = itemQuantity;
                box.SerialNumber = serialNumber;
                box.PriceBox = itemPrice * itemQuantity;
                sorted.Add(box.PriceBox);
                boxes.Add(box);
            }
            boxes = boxes.OrderBy(x => x.PriceBox).ToList();
            boxes.Reverse();
            foreach (Box box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine("-- {0} - ${1:f2}: {2}", box.Item.Name, box.Item.Price, box.Quantity);
                Console.WriteLine("-- ${0:0.00#}", box.PriceBox);
            }
        }
    }
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal PriceBox { get; set; }
    }
}
