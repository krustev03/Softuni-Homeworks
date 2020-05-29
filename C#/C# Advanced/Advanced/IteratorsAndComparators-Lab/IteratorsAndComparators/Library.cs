using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private SortedSet<Book> books;

        public Library(params string[] books)
        {
            this.books = new SortedSet<Book>(new BookComparator());
        }

        public void AddBook(Book book)
        {
            this.books.Add(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            foreach (var book in this.books)
            {
                yield return book;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}
