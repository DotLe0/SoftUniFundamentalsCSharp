Dictionary<char,int> keyValuePairs = new Dictionary<char,int>();

string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

for (int i = 0; i < input.Length; i++)
{
	foreach (char item in input[i])
	{
		if (!keyValuePairs.ContainsKey(item))
		{
			keyValuePairs.Add(item, 1);
		}
		else
		{
			keyValuePairs[item] += 1;
		}
	}
}

foreach (var item in keyValuePairs)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}
