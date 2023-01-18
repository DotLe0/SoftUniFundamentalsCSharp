namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string money = Console.ReadLine();
            double sum = 0;

            while (money != "Start")
            {
                switch (double.Parse(money))
                {
                    case 0.1:
                    case 0.2:
                    case 0.5:
                    case 1:
                    case 2:
                        sum += double.Parse(money);
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {money}");
                        break;
                }
                money = Console.ReadLine();
            }

            string product = Console.ReadLine();


            while (product != "End")
            {
                if (product == "Nuts")
                {
                    if (sum >= 2.00)
                    {
                        sum -= 2.00;
                        Console.WriteLine("Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Water")
                {
                    if (sum >= 0.7)
                    {
                        sum -= 0.7;
                        Console.WriteLine("Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Crisps")
                {
                    if (sum >= 1.5)
                    {
                        sum -= 1.5;
                        Console.WriteLine("Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Soda")
                {
                    if (sum >= 0.8)
                    {
                        sum -= 0.8;
                        Console.WriteLine("Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Coke")
                {
                    if (sum >= 1.0)
                    {
                        sum -= 1.0;
                        Console.WriteLine("Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:F2}");
        }
    }
}