using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long blog post ";
            var shortenedPost = post.Shorten(10);

            Console.WriteLine(shortenedPost);
           
        }
    }
}
