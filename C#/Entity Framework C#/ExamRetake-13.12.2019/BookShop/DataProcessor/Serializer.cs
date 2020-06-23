namespace BookShop.DataProcessor
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;
    using AutoMapper.QueryableExtensions;
    using BookShop.DataProcessor.ExportDto;
    using Data;
    using Newtonsoft.Json;
    using Formatting = Newtonsoft.Json.Formatting;

    public class Serializer
    {
        public static string ExportMostCraziestAuthors(BookShopContext context)
        {
            var authors = context
                .Authors
                .Select(x => new
                {
                    AuthorName = x.FirstName + " " + x.LastName,
                    Books = x.AuthorsBooks.Where(ab => ab.AuthorId == x.Id).Select(s => new
                    {
                        BookName = s.Book.Name,
                        BookPrice = s.Book.Price.ToString("F2")
                    })
                    .OrderByDescending(b => b.BookPrice)
                    .ToArray()
                })
                .ToArray();

            var resultAuthors = authors.OrderByDescending(x => x.Books.Length).ThenBy(x => x.AuthorName);
               

            return JsonConvert.SerializeObject(resultAuthors, Formatting.Indented);
        }

        public static string ExportOldestBooks(BookShopContext context, DateTime date)
        {
            
             StringBuilder sb = new StringBuilder();
         
                
            var books = context
                .Books
                .Where(b => b.PublishedOn.Ticks < date.Ticks && b.Genre.ToString() == "Science")
                .Select(x => new ExportBookDto() 
                { 
                    Name = x.Name,
                    Date = x.PublishedOn.ToString("d"),
                    Pages = x.Pages
                })
                .OrderByDescending(b => b.Pages).ThenByDescending(b => b.Date)
                .ToArray()
                .Take(10);

            var xmlSerializer = new XmlSerializer(typeof(ExportBookDto[]), new XmlRootAttribute("Books"));

            var namespaces = new XmlSerializerNamespaces(new[]
            {
                XmlQualifiedName.Empty
            });
            xmlSerializer.Serialize(new StringWriter(sb), books, namespaces);

            return sb.ToString().TrimEnd();
        }
    }
}