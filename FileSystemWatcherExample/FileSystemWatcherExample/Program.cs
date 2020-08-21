using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSystemWatcherExample
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher watcher = new FileSystemWatcher(@"C:\Users\Curso\Desktop\Test");
            watcher.EnableRaisingEvents = true;
            watcher.IncludeSubdirectories = true;

            //add event hanlders
            watcher.Changed += watcher_Changed;
            watcher.Created += watcher_Created;
            watcher.Deleted += watcher_Deleted;
            watcher.Renamed += watcher_Renamed;

            Console.Read(); //dont forget to stopthe program at this line.
        }

        private static void watcher_Renamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("File: {0} renamed to {1} at time: {2}", e.OldName, e.Name, DateTime.Now.ToLocalTime());
        }

        private static void watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File: {0} deleted at time: {1}", e.Name, DateTime.Now.ToLocalTime()); ;
        }

        private static void watcher_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File: {0} created at time: {1}", e.Name, DateTime.Now.ToLocalTime()); ;
        }

        private static void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File: {0} changed at time: {1}", e.Name, DateTime.Now.ToLocalTime()); ;
        }
    }
}
