while (true)
{
	string input = Console.ReadLine();

	if (input == "end")
	{
		break;
	}

	char[] reversedWord = input.ToCharArray();
	Array.Reverse(reversedWord);
    Console.WriteLine($"{input} = {new string(reversedWord)}");
}
