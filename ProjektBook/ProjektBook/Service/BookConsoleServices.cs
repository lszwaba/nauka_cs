using System;
using System.Collections.Generic;
using ProjektBook.Model;

namespace ProjektBook.Service
{
    class BookConsoleServices
    {
        public Book GetBookData(int index)
        {            
            Console.Write("Podaj autora:\n");
            string author = Console.ReadLine();
            Console.Write("Podaj tytuł:\n");
            string title = Console.ReadLine();
            Book book = new Book {Author = author, titleBook = title, ID = index };
            return book;
        }
        public void BookPrint(List<Book> books)
        {
            
            foreach (var bookInfo in books)
            {
                Console.WriteLine($"{bookInfo.ID}. {bookInfo.titleBook} by {bookInfo.Author}.");
            }
        }
    }
}
