namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ordersCount = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            double pricePerCapsule = 0;
            int days = 0, capsulesCount = 0;


            for (int i = 0; i < ordersCount; i++)
            {
                pricePerCapsule = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                capsulesCount = int.Parse(Console.ReadLine());

                double coffeePrice = ((days * capsulesCount) * pricePerCapsule);
                totalPrice += coffeePrice;
                Console.WriteLine($"The price for the coffee is: ${coffeePrice:f2}");
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}