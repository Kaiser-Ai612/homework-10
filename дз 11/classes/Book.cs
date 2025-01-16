using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_12.@classes
{
    internal class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string Izdat { get; }

        public Book(string title, string author, string izdat)
        {
            Title = title;
            Author = author;
            Izdat = izdat;
        }

        public override string ToString()
        {
            return $"название: {Title},автор : {Author}, издание: {Izdat}";
        }
    }
}
