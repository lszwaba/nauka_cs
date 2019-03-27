using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektBook.Model;

namespace ProjektBook.Service
{
    class BookConsoleServices
    {
        public void Execute()
        {
            
            for (int i =0; i <=11;i++)
            {
                Console.Write("Podaj autora:\n");
                string authot = Console.ReadLine();
                Console.Write("Podaj tytuł:\n");
                string title = Console.ReadLine();
            }
        }
    }
}
