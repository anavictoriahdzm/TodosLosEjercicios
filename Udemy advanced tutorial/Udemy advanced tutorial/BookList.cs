﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_advanced_tutorial
{
    public class BookList
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }
        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }


    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }
    }

    public class GenericList<T>
    {
        public void Add(T value)
        {

        }
        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    //public class ObjectList
    //{
    //    public void Add(object value)
    //    {

    //    }
    //    public object this[int index]
    //    {
    //        get { throw new NotImplementedException(); }
    //    }
    //}
}
