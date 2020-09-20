using System;
using System.IO;

namespace Pr2S1._2__FileWatchingDemo_
{
    
    class Program
    {
        

        static void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Changed: {0}", e.FullPath);
        }


        static void Main(string[] args)
        {
            FileSystemWatcher watcher = new FileSystemWatcher("C:\\");
            
            watcher.Filter = "*.ini";
            watcher.IncludeSubdirectories = true;
            watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.Size;
            watcher.Changed += new FileSystemEventHandler(watcher_Changed);
            

            

        }
    }
}
