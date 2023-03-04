List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

SortedDictionary<int, int> sortedNumbers = new SortedDictionary<int, int>();

foreach (var number in numbers)
{
	if (!sortedNumbers.ContainsKey(number))
	{
		sortedNumbers.Add(number, 1);
	}
	else
	{
		sortedNumbers[number]++;
	}
}

foreach (var item in sortedNumbers)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}