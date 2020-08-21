using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //Whitnout Linq
            //var cheapBooks = new List<Book>();
            ////foreach (var book in books)
            ////{
            ////    if (book.Price < 10)
            ////        cheapBooks.Add(book);
            ////}
            //foreach (var book in books)
            //    Console.WriteLine(book.Title + " " + book.Price);

            //With Linq
            var cheapBooks = books.Where(b => b.Price < 10);
            foreach (var book in books)
                Console.WriteLine(book.Title + " " + book.Price);

        }
    }
}
