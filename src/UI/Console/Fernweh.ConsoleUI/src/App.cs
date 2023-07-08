namespace Fernweh.ConsoleUI;

public class App
{   
    private ITplDataService _tplDataService;
    public App(ITplDataService tplDataService) {
        _tplDataService = tplDataService;
    }

    public async Task RunAsync()
    {
        Console.WriteLine("I LIVE!");
        var bookQry = new BooksFindQry("a");
        var books = await _tplDataService.BooksFindAsync(bookQry);
        foreach(var book in books) {
            Console.WriteLine($"{book.Title}");
        }
    }
}