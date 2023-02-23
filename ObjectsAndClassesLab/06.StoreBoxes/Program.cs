namespace _06.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxs = new List<Box>();
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "end")
                {
                    break;
                }

                Item item = new Item(input[1], decimal.Parse(input[3]));

                decimal PriceForBox = int.Parse(input[2]) * decimal.Parse(input[3]);

                Box box = new Box(input[0], item, int.Parse(input[2]), PriceForBox);

                boxs.Add(box);
            }

            foreach (Box box in boxs.OrderByDescending(x => x.PriceForBox))
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:F2}");
            }
        }
    }

    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }

    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForBox { get; set; }
        public Box(string serialNumber, Item item, int itemQuantity, decimal priceForBox)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
            PriceForBox = priceForBox;
        }
        public override string ToString()
        {
            return $"{SerialNumber} {Item} { ItemQuantity} {PriceForBox}";
        }
    }
}