using System.Security.Cryptography.X509Certificates;

namespace _03.Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("_");
                Song song = new Song(input[0], input[1], input[2]);
                songs.Add(song);
            }

            string type = Console.ReadLine();

            if (type == "all")
            {
                songs.ForEach(x => Console.WriteLine(string.Join(Environment.NewLine, x.Name)));
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == type)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }

    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }
    }
}