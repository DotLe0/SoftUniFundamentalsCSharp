namespace _03.Articles2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> list = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

                Article article = new Article(input[0], input[1], input[2]);
                list.Add(article);
            }

            Console.WriteLine(string.Join(Environment.NewLine,list));
        }
    }

    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}