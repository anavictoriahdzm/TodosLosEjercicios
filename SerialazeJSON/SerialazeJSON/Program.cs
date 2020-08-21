using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialazeJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            var person = new Persona
            {
                FirstName = "Ana",
                LastName = "Hernandez",
                age = 23
            };

            string json = JsonConvert.SerializeObject(person);
            string path = @"C:\Users\Curso\source\repos\Persona.txt";
            System.IO.File.WriteAllText(path, json);

            Console.WriteLine("Checar");
            Console.ReadLine();
        }
    }

    public class Persona
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int age { get; set; }
    }


}


