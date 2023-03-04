List<string> input = Console.ReadLine().Split().ToList();

Dictionary<string, int> pLanguaches = new Dictionary<string, int>();

foreach (var inputItem in input)
{
	string wordToLower = inputItem.ToLower();
	if (pLanguaches.ContainsKey(wordToLower))
	{
		pLanguaches[wordToLower]++;
	}
	else
	{
		pLanguaches.Add(wordToLower, 1);
	}
}

foreach (var pair in pLanguaches)
{
	if (pair.Value % 2 != 0)
	{
        Console.Write(pair.Key + " ");
    }
}
