﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_advanced_tutorial
{
     class Program
    {
        static void Main(string[] args)
        {
            var book = new BookList { Isbn = "1111", Titule = "C# Advanced" };
            //var numbers = new List();
            //numbers.Add(10);

            //var books = new BookList();
            //books.Add(book);

            var numbers = new GenericList<int>();
            numbers.Add(10);
            var books = new GenericList<BookList>();
            books.Add(new BookList());

            var dictionary = new GenericDictionary<string, Book>();
            directory.Add("1234", new Book());
        }
    }
}
