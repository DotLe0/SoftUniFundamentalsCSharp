List<Person> lstPersons = new List<Person>();

while (true)
{
    List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

    if (input[0] == "End")
    {
        break;
    }

    if (lstPersons.Select(x => x.Id).Contains(int.Parse(input[1])))
    {
        foreach (Person pr in lstPersons)
        {
            if (pr.Id == int.Parse(input[1]))
            {
                pr.Name = input[0];
                pr.Age = int.Parse(input[2]);
            }
        }
        continue;
    }

    Person person = new Person(input[0],int.Parse(input[1]),int.Parse(input[2]));
    lstPersons.Add(person);
}

foreach (Person item in lstPersons.OrderBy(x => x.Age))
{
    Console.WriteLine(item.ToString());
}

class Person
{
    public Person(string name, int id, int age)
    {
        Name = name;
        Id = id;
        Age = age;
    }

    public string Name { get; set; }
    public int Id { get; set; }
    public int Age { get; set; }
    public override string ToString()
    {
        return $"{Name} with ID: {Id} is {Age} years old.";
    }
}
