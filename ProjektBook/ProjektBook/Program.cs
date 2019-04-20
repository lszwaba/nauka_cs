using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektBook.Service;
using ProjektBook.Model;

namespace ProjektBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var booklist = new List<Book>();
            //new BookManagmentServices().Execute();
            //new BookConsoleServices().Execute();
            booklist = new BookAdder().BookAdd();
            new BookAdder().BookPrint(booklist);
        }
    }
}
