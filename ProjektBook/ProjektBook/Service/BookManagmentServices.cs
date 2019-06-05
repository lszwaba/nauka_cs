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
        private static List<Book> bookListMain = new List<Book>();
        
        public void Manage()
        {
            var bookAdder = new BookAdder();
            var bookConsoleServices = new BookConsoleServices();
            bookAdder.BookAdd();
            bookConsoleServices.BookPrint(bookListMain);
            //ExecuteFor();
            //
        }
        public List<Book> GetBooks()
        {
            return bookListMain;            
        }
        public void SetBook(Book book)
        {
            
            bookListMain.Add(book);
            
        }
        
        /*
        public void ExecuteFor()
        {
            
            for(int i = 1; i< 11; i++)
            {
                GetBooks( i);
            }
        }
        public void ExecuteWhile()
        {
            
            int indeks = 0;
            while (indeks <= 10)
            {
                GetBooks( indeks);
            }
        }
        public void ExecuteDoWhile()
        {
            
            int indeks = 0;
            do
            {
                GetBooks( indeks);
            }
            while (indeks <= 10);           
        }
        */
    }
}
