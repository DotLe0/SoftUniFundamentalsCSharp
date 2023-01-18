namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int numberOfPeople);
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double priceOfPerson = 0;

            if (type == "Students")
            {
                if (day == "Friday")
                {
                    priceOfPerson = 8.45;
                }
                else if (day == "Saturday")
                {
                    priceOfPerson = 9.80;
                }
                else if (day == "Sunday")
                {
                    priceOfPerson = 10.46;
                }

                if (numberOfPeople >= 30)
                {
                    priceOfPerson *= 0.85;
                }
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    priceOfPerson = 10.90;
                }
                else if (day == "Saturday")
                {
                    priceOfPerson = 15.60;
                }
                else if (day == "Sunday")
                {
                    priceOfPerson = 16;
                }

                if (numberOfPeople >= 100)
                {
                    numberOfPeople -= 10;
                }
            }
            else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    priceOfPerson = 15;
                }
                else if (day == "Saturday")
                {
                    priceOfPerson = 20;
                }
                else if (day == "Sunday")
                {
                    priceOfPerson = 22.5;
                }

                if (numberOfPeople >= 10 && numberOfPeople <= 20)
                {
                    priceOfPerson *= 0.95;
                }
            }

            double totalPrice = priceOfPerson * numberOfPeople;
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}