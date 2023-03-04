Dictionary<string, double> mine = new Dictionary<string, double>();

while (true)
{
    string resourse = Console.ReadLine();
	if (resourse == "stop")
	{
		break;
	}

	double quantity = double.Parse(Console.ReadLine());

	if (!mine.ContainsKey(resourse))
	{
		mine.Add(resourse, quantity);
		continue;
	}

	mine[resourse] += quantity;
}

foreach(var kvp in mine)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
}
