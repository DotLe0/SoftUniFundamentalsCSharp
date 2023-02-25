namespace _02.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputArticle = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();    
            Article article = new Article(inputArticle[0], inputArticle[1], inputArticle[2]);
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (input[0] == "Edit")
                {
                    article.Edit(input[1]);
                }
                else if (input[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(input[1]);
                }
                else if (input[0] == "Rename")
                {
                    article.Rename(input[1]);
                }
            }
            Console.WriteLine(article.ToString());
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

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }
        public void ChangeAuthor(string  newAuthor)
        {
            this.Author = newAuthor;
        }
        public void Rename(string newName)
        {
            this.Title= newName;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}