using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symulator_bibloiteki
{
    internal class Book: LibraryItem, IBorrowable
    {
        private string autor;
        private string pages;
    }
}
