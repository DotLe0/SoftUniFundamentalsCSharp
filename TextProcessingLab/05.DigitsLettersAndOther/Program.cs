string input = Console.ReadLine();

List<char> letters = new List<char>();
List<char> digits = new List<char>();
List<char> symbols = new List<char>();

for (int i = 0; i < input.Length; i++)
{
	if (char.IsLetter(input[i]))
	{
		letters.Add(input[i]);
	}
	else if (char.IsDigit(input[i])) 
	{
		digits.Add(input[i]); 
	}
	else if (input[i] >= 33 && input[i] <= 64)
	{
		symbols.Add(input[i]);
	}
	else if (char.IsSymbol(input[i]))
	{
		symbols.Add(input[i]);
	}
}

Console.WriteLine(string.Join("", digits));
Console.WriteLine(string.Join("", letters));
Console.WriteLine(string.Join("", symbols));
