using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using лаба_12.classes;

namespace лаба_12.@classes
{
    internal class Sravn
    {
        public static int CompareByTitle(Book book1, Book book2) => string.Compare(book1.Title, book2.Title);

        public static int CompareByAuthor(Book book1, Book book2)
        {
            return string.Compare(book1.Author, book2.Author);
        }

        public static int CompareByPublisher(Book book1, Book book2)
        {
            return string.Compare(book1.Izdat, book2.Izdat);
        }
    }
}
