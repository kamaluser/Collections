using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Exceptions
{
    internal class BookLimitException:Exception
    {
        public BookLimitException() : base("Library is full. Cannot add more books.")
        {

        }
    }
}
