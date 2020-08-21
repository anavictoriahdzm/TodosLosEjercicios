using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var randomValues = Enumerable.Range(1, 10)
                .Select(_ => rand.Next(10) - 5);
            Console.WriteLine(randomValues);
        }
    }
}
