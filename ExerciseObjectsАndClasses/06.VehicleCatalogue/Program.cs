List<Vehicle> lstVehicle = new List<Vehicle>();

while (true)
{   
    List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

    if (input[0] == "End")
    {
        break;
    }
    Vehicle vihicle = new Vehicle(input[0], input[1], input[2], double.Parse(input[3]));
    lstVehicle.Add(vihicle);
}

while (true)
{
    string input = Console.ReadLine();

    if (input == "Close the Catalogue")
    {
        break;
    }

    foreach (var item in lstVehicle)
    {
        if (item.Model == input)
        {
            Console.WriteLine(item.ToString());
        }        
    }
}

if (lstVehicle.Count != 0)
{
    double carsAverageHoursePower = lstVehicle.Where(x => x.Type == "car").Average(x => x.HoursePower);
    double truckAverageHoursePower = lstVehicle.Where(x => x.Type == "truck").Average(x => x.HoursePower);

    Console.WriteLine($"Cars have average horsepower of: {carsAverageHoursePower:F2}.");
    Console.WriteLine($"Trucks have average horsepower of: {truckAverageHoursePower:F2}.");
}

class Vehicle
{
    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public double HoursePower { get; set; }

    public Vehicle(string type, string model, string color, double hoursePower)
    {
        Type = type;
        Model = model;
        Color = color;
        HoursePower = hoursePower;
    }
    public override string ToString()
    {
        string actualType = "Truck";
        if (Type == "car")
        {
            actualType = "Car";
        }
        return $"Type: {actualType}\nModel: {Model}\nColor: {Color}\nHorsepower: {HoursePower}";
    }
}
