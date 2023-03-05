Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

while (true)
{
    List<string> list = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries).ToList();

    if (list[0] == "end")
    {
        break;
    }

    if (!dict.ContainsKey(list[0].Trim()))
    {
        dict.Add(list[0].Trim(), new List<string> { list[1] });
        continue;
    }

    dict[list[0].Trim()].Add(list[1]);
}

foreach (var kvp in dict)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}\n--{string.Join("\n--", kvp.Value)}");
}

