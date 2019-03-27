using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektBook.Model;

namespace ProjektBook.Service
{
    class BookManagmentServices
    {
        public void Manage()
        {
            //
        }
        public void ExecuteFor()
        {
            var booklist = new List<Book>();
            for(int i = 1; i< 11; i++)
            {
                Book bookToAdd = new Book();
                bookToAdd.ID = i;
                bookToAdd.titleBook = "title_" + i.ToString();
                bookToAdd.Author = "Ziomek";
                booklist.Add(bookToAdd);
            }
        }
        public void ExecuteWhile()
        {
            var booklist = new List<Book>();
            int indeks = 0;
            while (indeks <= 10)
            {
                Book bookToAdd = new Book();
                bookToAdd.ID = indeks;
                bookToAdd.titleBook = "title_" + indeks.ToString();
                bookToAdd.Author = "Ziomek";
                booklist.Add(bookToAdd);
                indeks++;
            }
        }
        public void ExecuteDoWhile()
        {
            var booklist = new List<Book>();
            int indeks = 0;
            do
            {
                Book bookToAdd = new Book();
                bookToAdd.ID = indeks;
                bookToAdd.titleBook = "title_" + indeks.ToString();
                bookToAdd.Author = "Ziomek";
                booklist.Add(bookToAdd);
                indeks++;
            }
            while (indeks <= 10);
           
        }

    }
}
