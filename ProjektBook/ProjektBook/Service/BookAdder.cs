using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektBook.Model;
using ProjektBook.Service;

namespace ProjektBook.Service
{
    class BookAdder
    {
        public void BookAdd()
        {
            var booklist = new List<Book>();
            Console.Write("Podaj ilość książęk którą chcesz wporowadzić:\n");
            int number = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Book bookToAdd = new Book();
                Console.Write("Podaj autora:\n");
                string author = Console.ReadLine();
                Console.Write("Podaj tytuł:\n");
                string title = Console.ReadLine();
                bookToAdd.ID = i;
                bookToAdd.titleBook = title;
                bookToAdd.Author = author;
                booklist.Add(bookToAdd);
                Console.Write("\n");
            }
            foreach(Book a in booklist)
            {
                Console.WriteLine(a.ID);
                Console.WriteLine(a.Author);
                Console.WriteLine(a.titleBook);
                Console.Write("\n");
            }
        }
    }
}
