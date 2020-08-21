using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpretions
{
    class Program
    {
        static void Main(string[] args)
        {
            //args => expression
            //number => number * number


            //si no se tiene argumentos () => code...
            //si se tiene un argumento x => code.. (withoout parentesis)
            //many arguments (x, y, z) => code... (With parentesis)

            //EXAMPLE 1
            //Func<int, int> square = number => number * number;
            //Console.WriteLine(square(5));

            //EXAMPLE2
            //const int factor = 5;
            //Func<int, int> multipler = n => n * factor;
            //var result = multipler(10);
            //Console.WriteLine(result);

            //EXAMPLE3
            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

        }

        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
        //static int Square(int number)
        //{
        //    return number * number;
        //}
    }
}
