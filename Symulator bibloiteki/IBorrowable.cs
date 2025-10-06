using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symulator_bibloiteki
{
    interface IBorrowable
    {
        bool IsBorrowed { get; }
        void Borrow();
        void Return();

    }
}
