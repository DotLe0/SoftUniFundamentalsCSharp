Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    if (!students.ContainsKey(name))
    {
        students.Add(name, new List<double>());
        students[name].Add(grade);
        continue;
    }

    students[name].Add(grade);
}

var filteredStudents = students.Where(x => x.Value.Average() >= 4.50);

foreach (var student in filteredStudents)
{
    Console.WriteLine($"{student.Key} -> {student.Value.Average():F2}");
}
