var folderStartsWithIgnorePatternsInsensitive = new List<string> {
    "bin",
    "obj",
    "properties",
    ".",
    "workspaceConfiguration"
    };

var fileMeaningfulEndsWithSensitive = new List<string> {
    "ViewModel",
    "Configuration",
    "Mapper",
    "VO"
    };

var folderToStartWith = Environment.CurrentDirectory;

Console.WriteLine($"Enter folder to start with: [{folderToStartWith}]");
folderToStartWith = Console.ReadLine();


