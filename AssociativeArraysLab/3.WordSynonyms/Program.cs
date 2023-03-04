using System.Globalization;

int n = int.Parse(Console.ReadLine());

Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

for (int i = 0; i < n; i++)
{
    string word = Console.ReadLine();
    string synonim = Console.ReadLine();

    if (!dict.ContainsKey(word))
    {
        dict.Add(word, new List<string>());
        dict[word].Add(synonim);
    }
    else
    {
        dict[word].Add(synonim);
    }
}
Console.WriteLine();
foreach (var item in dict)
{
    Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
}