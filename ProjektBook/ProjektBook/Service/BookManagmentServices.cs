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
            ExecuteFor();
            //
        }
        public void GetBook( int i)
        {
            var booklist = new List<Book>();
            Book bookToAdd = new Book();
            bookToAdd.ID = i;
            bookToAdd.titleBook = "title_" + i.ToString();
            bookToAdd.Author = "Ziomek";
            booklist.Add(bookToAdd);
        }
        public void ExecuteFor()
        {
            
            for(int i = 1; i< 11; i++)
            {
                GetBook( i);
            }
        }
        public void ExecuteWhile()
        {
            
            int indeks = 0;
            while (indeks <= 10)
            {
                GetBook( indeks);
            }
        }
        public void ExecuteDoWhile()
        {
            
            int indeks = 0;
            do
            {
                GetBook( indeks);
            }
            while (indeks <= 10);
           
        }

    }
}
