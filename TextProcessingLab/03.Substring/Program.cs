string wordToLookFor = Console.ReadLine();
string word = Console.ReadLine();

while (true)
{
	if (word.IndexOf(wordToLookFor) != -1)
	{ 
		int start = word.IndexOf(wordToLookFor);
		word = word.Remove(start, wordToLookFor.Length);
		continue;
	}
	break;
}

Console.WriteLine(word);
