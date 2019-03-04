using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBook.Model
{
    class BookStore
    {
        public String Name
        {
            get;
            set;
        }

        public String Adress
        {
            get;
            set;
        }

        public long ID
        {
            get;
            set;
        }
        public List<Book> Books {
            get;
            set;
        }

    }
}
