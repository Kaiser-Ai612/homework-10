using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Создать класс, являющийся контейнером для множества книг (массив книг).
В этом классе предусмотреть метод сортировки книг. Критерий сортировки определяется
экземпляром делегата, который передается методу в качестве параметра. Каждый экземпляр
делегата должен сравнивать книги по какому-то одному полю: названию, автору,
издательству.
 */

namespace лаба_12.@classes
{
    internal class Contain
    {
        private Book[] books;

        public Contain(Book[] books) 
        {
            this.books = books;
        }

        public void Sort(Sravn comparer)
        {
            Array.Sort(books, (book1, book2) => comparer(book1, book2));
        }

        public void DisplayBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
