using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektBook.Service;

namespace ProjektBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //new BookManagmentServices().Execute();
            new BookConsoleServices().Execute();
        }
    }
}
