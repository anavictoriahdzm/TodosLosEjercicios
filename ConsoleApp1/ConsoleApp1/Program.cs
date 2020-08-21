using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int x = 5;
        int y = x;
        Console.WriteLine("x={0}, y={1}", x, y);
        x = 25;
        Console.WriteLine("x={0}, y={1}", x,y);
        double[] arr1 = { 1, 2 };
        double[] arr2 = arr1;
        arr2[0] = 10;
        Console.WriteLine("The value at index 0 is {0}", arr1[0]);




    }
}
    
