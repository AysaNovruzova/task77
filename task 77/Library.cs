using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_77
{
    internal class Library
    {
        private book[] _books;

        public Library()
        {
            _books = new book[0]; 
        }

        public void AddBook(book book)
        {
            Array.Resize(ref _books, _books.Length + 1);
            _books[_books.Length - 1] = book;
        }

        public book[] GetFilteredBooks(string genre)
        {
            return Array.FindAll(_books, b => b.Genre == genre);
        }

        public book[] GetFilteredBooks(double minPrice, double maxPrice)
        {
            return Array.FindAll(_books, b => b.Price >= minPrice && b.Price <= maxPrice);
        }

        public void ShowAllBooks()
        {
            for (int i = 0; i < _books.Length; i++)
            {
                _books[i].ShowInfo();
            }
        }
    }
}
