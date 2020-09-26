using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> input = Console.ReadLine().Split(", ").ToList();

                string title = input[0];
                string content = input[1];
                string author = input[2];

                articles.Add(new Article(title, content, author));
            }
            string something = Console.ReadLine();
            if (something == "author")
            {
                articles = articles.OrderBy(e => e.Author).ToList();
            }
            else if (something == "title")
            {
                articles = articles.OrderBy(e => e.Title).ToList();
            }
            else if (something == "content")
            {
                articles = articles.OrderBy(e => e.Content).ToList();
            }
            foreach (var article in articles)
            {
                Console.WriteLine(article.ToString());
            }
        }
    }

    internal class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}