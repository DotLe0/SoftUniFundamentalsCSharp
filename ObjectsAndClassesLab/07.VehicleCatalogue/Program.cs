namespace _07.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            while (true)
            {
                string[] input = Console.ReadLine().Split("/");
                if (input[0] == "end")
                {
                    break;
                }

                if (input[0] == "Car")
                {
                    Car car = new Car(input[1], input[2], int.Parse(input[3]));
                    cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck(input[1], input[2], double.Parse(input[3]));
                    trucks.Add(truck);
                }
            }

            Catalog catalog = new Catalog(cars, trucks);

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in catalog.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HoursePower}hp");
                }
            }

            if (catalog.Truks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in catalog.Truks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }

        public Truck(string brand, string model, double weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HoursePower { get; set; }

        public Car(string brand, string model, int hoursePower)
        {
            Brand = brand;
            Model = model;
            HoursePower = hoursePower;
        }
    }

    class Catalog
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Truks { get; set; }

        public Catalog(List<Car> cars, List<Truck> truks)
        {
            Cars = cars;
            Truks = truks;
        }
    }
}