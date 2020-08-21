using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleClient.ServiceAcademy;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();

            Console.WriteLine(client.GetData(5));

            CompositeType T = new CompositeType();
            T.BoolValue = true;
            T.StringValue = "Ana";

            CompositeType resp = client.GetDataUsingDataContract(T);

            Console.WriteLine(resp.StringValue + " " + resp.BoolValue);

            foreach (var item in client.GetListYoutube("J Balvin"))
            {
                Console.WriteLine(item.Id.VideoId);
                
            }

            Console.ReadKey();
        }
    }
}
