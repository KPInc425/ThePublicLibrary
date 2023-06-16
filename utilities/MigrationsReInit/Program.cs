using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Timers;

namespace MigrationsReInit
{
    class Program
    {
        static void Main(string[] args)
        {
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
            while (agreeToSearchFolder != "Y")
            {
                Console.WriteLine($"Provide Y to apply, or ctrl-c to quit");
                agreeToSearchFolder = Console.ReadLine();
            }

            directories = new DirectoryInfo(upToSrcRootFolderToConsider);
            var searchDirectories = directories.EnumerateDirectories("Migrations", SearchOption.AllDirectories);
            foreach (var directory in searchDirectories)
            {
                if (!directory.FullName.ToLower().Contains("identity"))
                {
                    foundDirectories.Add(directory);
                }
            }

            Console.WriteLine("Clearing and resetting Migrations Folders this can take a bit");
            foreach (var dir in foundDirectories)
            {
                Console.WriteLine($"\rMigrating {dir.FullName}");
            }

            Console.WriteLine("If the list above looks good, press Y to continue");

            var input = Console.ReadLine();
            if (input == "Y")
            {
                foreach (var dir in foundDirectories)
                {
                    Directory.Delete(dir.FullName, true);
                    Directory.CreateDirectory(dir.FullName);

                    var dropDb = new ProcessStartInfo();
                    dropDb.FileName = "dotnet";
                    dropDb.Arguments = "ef database drop -f";
                    dropDb.WorkingDirectory = $"{dir.FullName}\\..\\";
                    dropDb.UseShellExecute = true;
                    var p = Process.Start(dropDb);
                    p.WaitForExit();


                    var startInfo = new ProcessStartInfo();
                    startInfo.FileName = "dotnet";
                    startInfo.Arguments = "ef migrations add init";
                    startInfo.WorkingDirectory = $"{dir.FullName}\\..\\";
                    startInfo.UseShellExecute = true;
                    Process proc = Process.Start(startInfo);
                    proc.WaitForExit();
                }
            }
        }
    }
}
