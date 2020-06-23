namespace BookShop.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using BookShop.Data.Models;
    using BookShop.Data.Models.Enums;
    using BookShop.DataProcessor.ImportDto;
    using Data;
    using Newtonsoft.Json;
    using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedBook
            = "Successfully imported book {0} for {1:F2}.";

        private const string SuccessfullyImportedAuthor
            = "Successfully imported author - {0} with {1} books.";

        public static string ImportBooks(BookShopContext context, string xmlString)
        {
            var xmlSerializer = new XmlSerializer(typeof(ImportBookDto[]), new XmlRootAttribute("Books"));
            var bookDtos = (ImportBookDto[])xmlSerializer.Deserialize(new StringReader(xmlString));

            var sb = new StringBuilder();
            var validBooks = new List<Book>();

            foreach (var bookDto in bookDtos)
            {
                if (IsValid(bookDto))
                {
                    var book = new Book()
                    {
                        Name = bookDto.Name,
                        Genre = (Genre)bookDto.Genre,
                        Price = bookDto.Price,
                        Pages = bookDto.Pages,
                        PublishedOn = DateTime.ParseExact(bookDto.PublishedOn, "MM/dd/yyyy", CultureInfo.InvariantCulture)
                    };

                    if (IsValid(book))
                    {
                        sb.AppendLine(string.Format(SuccessfullyImportedBook, book.Name, book.Price));
                        validBooks.Add(book);
                    }

                    else
                    {
                        sb.AppendLine(ErrorMessage);
                    }
                }
                else
                {
                    sb.AppendLine(ErrorMessage);
                }
            }

            context.Books.AddRange(validBooks);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportAuthors(BookShopContext context, string jsonString)
        {

            var authorsDto = JsonConvert.DeserializeObject<ImportAuthorDto[]>(jsonString);

            var sb = new StringBuilder();
            var validAuthors = new List<Author>();
     

            foreach (var authorDto in authorsDto)
            {
                if (!IsValid(authorDto) || context.Authors.Any(a => a.Email == authorDto.Email))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var author = new Author()
                {
                    FirstName = authorDto.FirstName,
                    LastName = authorDto.LastName,
                    Email = authorDto.Email,
                    Phone = authorDto.Phone
                };

                int count = 0;
                foreach (var book in authorDto.Books)
                {
                    if (context.Books.Any(b => b.Id == book.Id) == false)
                    {
                        continue;
                    }

                    var authorBook = new AuthorBook()
                    {
                        AuthorId = author.Id,
                        BookId = book.Id
                    };

                    count++;
                    context.AuthorsBooks.Add(authorBook);
                }

                if (count == 0)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                validAuthors.Add(author);
                sb.AppendLine(string.Format(SuccessfullyImportedAuthor, author.FirstName + " " + author.LastName, count));
            }

            context.Authors.AddRange(validAuthors);
            context.SaveChanges();

            var result = sb.ToString().TrimEnd();

            return result;
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}