﻿using System;

namespace IteratorsAndComparators
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            var library = new Library();
            library.AddBook(bookOne);
            library.AddBook(bookTwo);
            library.AddBook(bookThree);

            foreach (var book in library)
            {
                Console.WriteLine(book);
            }
        }
    }
}