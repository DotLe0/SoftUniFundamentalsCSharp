Dictionary<string, double[]> shop = new Dictionary<string, double[]>();

while (true)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

	if (input[0] == "buy")
	{
		break;
	}

	double[] priceAndQuantity = input[1..3].Select(double.Parse).ToArray();

	if (!shop.ContainsKey(input[0]))
	{
		shop.Add(input[0], new double[1]);
		shop[input[0]] = priceAndQuantity;
		continue;
	}

	if (shop[input[0]][0] != priceAndQuantity[0])
	{
		shop[input[0]][0] = priceAndQuantity[0];
	}

	shop[input[0]][1] += priceAndQuantity[1];
}

foreach (var kvp in shop)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value[0] * kvp.Value[1]:F2}");
}
