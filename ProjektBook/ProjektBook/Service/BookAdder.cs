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
            
            var console = new BookConsoleServices();
            var bookManagmentServices = new BookManagmentServices();
            Console.Write("Podaj ilość książęk którą chcesz wporowadzić:\n");
            int number = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                var book = console.GetBookData(i);
                bookManagmentServices.SetBook(book);
                
                Console.Write("\n");
            }
                        
                
            
        }
        
    }
}
