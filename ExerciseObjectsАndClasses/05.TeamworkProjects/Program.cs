namespace _05.TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                List<string> inputForTeams = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries).ToList();

                if (teams.Select(x => x.Name).Contains(inputForTeams[1]))
                {
                    Console.WriteLine($"Team {inputForTeams[1]} was already created!");
                    continue;
                }
                if (teams.Select(x => x.TeamCreator).Contains(inputForTeams[0]))
                {
                    Console.WriteLine($"{inputForTeams[0]} cannot create another team!");
                    continue;
                }

                Console.WriteLine($"Team {inputForTeams[1]} has been created by {inputForTeams[0]}!");
                Team team = new Team(inputForTeams[0], inputForTeams[1]);
                teams.Add(team);
            }
            
            while (true)
            {
                string[] inputForMembers = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (inputForMembers[0] == "end of assignment")
                {
                    break;
                }

                if (!teams.Select(x => x.Name).Contains(inputForMembers[1]))
                {
                    Console.WriteLine($"Team {inputForMembers[1]} does not exist!");
                    continue;
                }

                if (teams.Select(x => x.TeamCreator).Contains(inputForMembers[0]) 
                    || teams.SelectMany(x => x.Members).Contains(inputForMembers[0]))
                {
                    Console.WriteLine($"Member {inputForMembers[0]} cannot join team {inputForMembers[1]}!");
                    continue;
                }

                for (int i = 0; i < teams.Count; i++)
                {
                    if (teams[i].Name == inputForMembers[1])
                    {
                        teams[i].Members.Add(inputForMembers[0]);
                    }
                }
            }

            var OrderedTeamsByCountAndName = teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name);

            foreach (Team item in OrderedTeamsByCountAndName)
            {
                if (item.Members.Count != 0)
                {
                    Console.WriteLine(item.Name);
                    Console.WriteLine("- " + item.TeamCreator);
                    foreach (string person in item.Members.OrderBy(x=>x))
                    {
                        Console.WriteLine("-- " + person);
                    }
                }
            }
            Console.WriteLine($"Teams to disband:");
            foreach (Team item in OrderedTeamsByCountAndName)
            {
                if (item.Members.Count == 0)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
    class Team
    {
        public Team(string teamCreator, string name)
        {
            TeamCreator = teamCreator;
            Name = name;
            Members = new List<string>();
        }

        public string TeamCreator { get; set; }
        public string Name { get; set; }
        public List<string> Members{ get; set; }
    }
}