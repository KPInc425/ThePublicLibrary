
using System.Net;
using System;
using System.Linq;
using System.Security.AccessControl;
using System.IO;

var folderStartsWithIgnorePatternsInsensitive = new List<string> {
    "\\bin",
    "\\obj",
    "\\properties",
    "\\.git",
    "\\.vscode",
    "\\workspaceConfiguration",
    "\\Migrations"
    };

var fileMeaningfulEndsWithSensitive = new List<string> {
    "ViewModel",
    "Configuration",
    "Mapper",
    "VO",
    ".csproj"
    };

var escapeBackToProject = "./../../../../";
var root = Path.Combine(Environment.CurrentDirectory, escapeBackToProject);

Console.WriteLine($"Enter folder to start with: [{root}]");

var folderToStartWith  = ""; // Console.ReadLine();
if(folderToStartWith == "") {
    folderToStartWith = root;
}

var directoryToStartWith = new DirectoryInfo(folderToStartWith);

var allDirectories = directoryToStartWith
    .GetDirectories("*", SearchOption.AllDirectories)
    .ToList()
    .Where(rs => !folderStartsWithIgnorePatternsInsensitive.Any(rss => rs.FullName.Contains(rss)))
    .OrderBy(rs => rs.FullName);

foreach(var directory in allDirectories) {
    Console.WriteLine(directory);
    var files = directory.GetFiles().Select(rs=>rs.Name);
    foreach(var file in files) {
        Console.WriteLine($"    {file}");
    }
}

