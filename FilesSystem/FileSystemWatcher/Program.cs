using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher watcher = new FileSystemWatcher(@"C:\Users\Curso\source\repos\FilesSystem\Customers.xml");

            watcher.EnableRaisingEvents = true;
            watcher.IncludeSubdirectories = true;

            //add Event Hanlders
            watcher.Changed += watcher_Changed;

            Console.Read(); // dont forget to stop the program at this line

        }

        private static void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            
        }
    }
}
