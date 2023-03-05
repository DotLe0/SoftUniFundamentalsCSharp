Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

while (true)
{
    List<string> list = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries).ToList();
    list[0] = list[0].Trim();
    if (list[0] == "end")
    {
        break;
    }

    if (!dict.ContainsKey(list[0]))
    {
        dict.Add(list[0], new List<string> { list[1] });
        continue;
    }

    dict[list[0]].Add(list[1]);
}

foreach (var kvp in dict)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}\n--{string.Join("\n--", kvp.Value)}");
}

