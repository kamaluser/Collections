using Collections.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Library
    {

        private List<string> books;
        private int _bookLimit;

        public Library(int _bookLimit)
        {
            this.books = new List<string>();
            this._bookLimit = _bookLimit;
        }
        public void AddBook(string  book)
        {
            if (books.Count < _bookLimit)
            {
                if (!books.Contains(book))
                {
                    books.Add(book);
                }
                else
                {
                    throw new BookExistsException();
                }
            }
            else
            {
                throw new BookLimitException();
            }
        }

        public bool RemoveBook(string book)
        {
            if (books.Contains(book))
            {
                books.Remove(book);
                Console.WriteLine("Removed Successfully!");
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DisplayAll()
        {
            foreach (var item in books)
            {
                Console.WriteLine(item);
            }
        }

        

        public void Search(string str)
        {
            List<string> newList = new List<string>();
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].ToLower().Contains(str.ToLower()))
                {
                    newList.Add(books[i]); 
                }
            }
            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
