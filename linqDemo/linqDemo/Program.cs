﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqDemo
{
    public class Params : IEnumerable<int>
    {
        private int a, b, c;

        public Params(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public IEnumerator<int> GetEnumerator()
        {
            yield return a;
            yield return b;
            yield return c;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public class Person
        {
            private string fistName, middleName, lastName;

            public Person(string fistName, string middleName, string lastName)
            {
                this.fistName = fistName;
                this.middleName = middleName;
                this.lastName = lastName;
            }

            public IEnumerable<string> Names
            {
                get
                {
                    yield return fistName;
                    yield return middleName;
                    yield return lastName;
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                var p = new Params(1, 2, 3);
                foreach (var x in p)
                {
                    Console.WriteLine(x);
                }

                var person = new Person("Ana", "Victoria", "Hernandez");
                foreach (var name in person.Names)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
