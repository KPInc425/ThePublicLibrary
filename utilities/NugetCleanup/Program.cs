using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Timers;

namespace NodePackagesCleanup
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(400);
            var spinnerState = -1;
            var timerPreText = "";
            timer.Enabled = false;
            timer.Elapsed += timer_Elapsed;

            List<DirectoryInfo> foundDirectories = new List<DirectoryInfo>();

            long totalSize = 0;
            Console.BackgroundColor = ConsoleColor.Black;

            var executeIn = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var upToSrcRootFolderToConsider = System.IO.Path.Combine(executeIn, "..\\..\\");

            var dirNameLower = new DirectoryInfo(executeIn).Name.ToLower();
            if ((dirNameLower.StartsWith("net") && dirNameLower.EndsWith("0")) || dirNameLower == "debug" || dirNameLower == "publish")
            {
                upToSrcRootFolderToConsider = System.IO.Path.Combine(upToSrcRootFolderToConsider, "..\\..\\..\\");
            }
            upToSrcRootFolderToConsider = System.IO.Path.Combine(upToSrcRootFolderToConsider, "src");
            
            DirectoryInfo directories = new DirectoryInfo(upToSrcRootFolderToConsider);
            Console.WriteLine($"\rThis will search directory {directories.FullName}");
            Console.WriteLine($"Provide Y to perform this initial task to search your system");
            var agreeToSearchFolder = Console.ReadLine();
            //var agreeToSearchFolder = "Y";
            while (agreeToSearchFolder != "Y")
            {
                Console.WriteLine($"Provide Y to apply, or ctrl-c to quit");
                agreeToSearchFolder = Console.ReadLine();
            }

            directories = new DirectoryInfo(upToSrcRootFolderToConsider);
            var searchDirectories = directories.EnumerateDirectories("node_modules", SearchOption.AllDirectories);
            foreach (var directory in searchDirectories)
            {
                if (directory.Parent.Name == "ClientApp")
                {
                    Console.WriteLine("\r" + directory.FullName);
                    Console.WriteLine("Calculating folder size");
                    timer.Enabled = true;
                    var size = GetDirectorySize(directory.FullName);
                    timer.Enabled = false;

                    totalSize += size;
                    Console.WriteLine($"\rFolder size {size:n0}mb                                                                                                                    ");
                    foundDirectories.Add(directory);
                }
            }


            string[] searchMasks = new[] { "Debug", "Release" };

            directories = new DirectoryInfo(upToSrcRootFolderToConsider);
            searchDirectories = searchMasks.SelectMany(rs => directories.EnumerateDirectories(rs, SearchOption.AllDirectories));
            foreach (var directory in searchDirectories)
            {
                if (directory.Parent.Name == "obj" || directory.Parent.Name == "bin")
                {
                    Console.WriteLine("\r" + directory.FullName);
                    Console.WriteLine("Calculating folder size");
                    timer.Enabled = true;
                    var size = GetDirectorySize(directory.FullName);
                    timer.Enabled = false;

                    totalSize += size;

                    Console.WriteLine($"\rFolder size {size:n0}mb");
                    foundDirectories.Add(directory);
                }
            }

            Console.WriteLine($"\rThis will recover {totalSize:n0}mb of space");
            Console.WriteLine($"Provide Y to perform this largerly irreversible task and remove all of the above listed folders from your system");
            var input = Console.ReadLine();
            while (input != "Y")
            {
                Console.WriteLine($"Provide Y to apply, or ctrl-c to quit");
                input = Console.ReadLine();
            }
            Console.WriteLine("Deleting Folders this can take a bit");
            timer.Enabled = true;
            foreach (var dir in foundDirectories)
            {
                Console.WriteLine($"\rDeleting {dir.FullName}                                                                                                      ");
                dir.Delete(true);
            }
            timer.Enabled = true;

            void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
            {

                // (>'-')> <('_'<) ^('_')\- \m/(-_-)\m/ <( '-')> \_( .")> <( ._.)-
                string[] spinner = {
                   /*  "m( o_o)m ",
                    "m( -_-)m ",
                    "m( ._.)m ",
                    "m(._. )m ",
                    "m( ._.)m ",
                    "m(._. )m ",
                    "m(-_-)m ",
                    "m(^_^)m ",
                    "m(@_@)m ",
                    "w(x_x)w ",       */            
                    @" (>","'-'",")",">",
                    @" <(","'_","'<)",
                    @" ^('",@"_')^",
                    @" \m/","(-_","-)",@"\m/",
                    @" <("," '","-')>",
                    @" <(","'","-' )>",
                    @" \",@"\","_("," .","\")>",
                    " <(\"",". ",")_","//",
                    " <", "( ", "._", ".)", ">", 
                    " <", "(", "._", ". )", ">", 
                    @" <("," ^","-^)>",
                    @" <(","^","-^ )>"
                    };
                spinnerState++;
                if (spinnerState > spinner.Length - 1)
                {
                    spinnerState = 0;
                }
                Console.Write($"{spinner[spinnerState]}");
            }
        }

        static long GetDirectorySize(string p)
        {
            // 1
            // Get array of all file names.
            string[] a = Directory.GetFiles(p, "*.*", SearchOption.AllDirectories);

            // 2
            // Calculate total bytes of all files in a loop.
            long b = 0;
            foreach (string name in a)
            {
                // 3
                // Use FileInfo to get length of each file.
                FileInfo info = new FileInfo(name);
                b += info.Length;
            }
            // 4
            // Return total size
            return b / 1024;
        }


    }
}
