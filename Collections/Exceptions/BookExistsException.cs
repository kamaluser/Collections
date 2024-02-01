using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Exceptions
{
    internal class BookExistsException:Exception
    {
        public BookExistsException():base("This Book Already Exists!")
        {

        }
    }
}
