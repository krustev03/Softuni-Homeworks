using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> articleParts = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Article article = new Article();
            article.Title = articleParts[0];
            article.Content = articleParts[1];
            article.Author = articleParts[2];
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string all = command.Substring(command.IndexOf(" ") + 1, command.Length - command.IndexOf(" ") - 1);
                
                switch (command.Substring(0, command.IndexOf(" ")))
                {
                    case "Edit:":
                        article.Edit(article, all);
                        break;
                    case "ChangeAuthor:":
                        article.ChangeAuthor(article, all);
                        break;
                    case "Rename:":
                        article.Rename(article, all);
                        break;
                }
            }
            article.PrintArticle(article);
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public void Edit(Article article, string newContent)
        {
            article.Content = newContent;
        }
        public void ChangeAuthor(Article article, string newAuthor)
        {
            article.Author = newAuthor;
        }
        public void Rename(Article article, string newTitle)
        {
            article.Title = newTitle;
        }
        public void PrintArticle(Article article)
        {
            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
        }
    }
}
