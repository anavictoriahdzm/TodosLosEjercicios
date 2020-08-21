using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase1.ServiceAcademy;

namespace clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceAcademy.Service1Client Client = new ServiceAcademy.Service1Client();
            Client.GetData(5);
            Console.WriteLine(Client.GetData(5));
        }
    }
}
