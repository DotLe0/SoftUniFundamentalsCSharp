Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    List<string> input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();

	if (input[0] == "register")
	{
		if (!keyValuePairs.ContainsKey(input[1]))
		{
			keyValuePairs.Add(input[1], input[2]);
            Console.WriteLine($"{input[1]} registered {input[2]} successfully");
			continue;
        }

        Console.WriteLine($"ERROR: already registered with plate number {input[2]}");
    }
	else if (input[0] == "unregister")
	{
		if (!keyValuePairs.ContainsKey(input[1]))
		{
            Console.WriteLine($"ERROR: user {input[1]} not found");
			continue;
        }

		keyValuePairs.Remove(input[1]);
		Console.WriteLine($"{input[1]} unregistered successfully");
    }
}

foreach (var item in keyValuePairs)
{
    Console.WriteLine($"{item.Key} => {item.Value}");
}
