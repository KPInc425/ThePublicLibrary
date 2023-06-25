namespace TPL.TplCore.Entities;
public class LibrarySection : BaseEntityTracked<Guid>
{
    public string Name { get; private set; }
    public LibrarySection(string name)
    {
        Name = Guard.Against.NullOrEmpty(name, "Library name is required");
    }
    private List<LibraryShelf> _shelves = new();
    public IEnumerable<LibraryShelf> Shelves => _shelves.AsReadOnly();

    public void AddBookToShelf(LibraryShelf libraryShelf)
    {
        _shelves.Add(libraryShelf);
    }
    public void AddBookToShelf(IEnumerable<LibraryShelf> libraryShelves)
    {
        _shelves.AddRange(libraryShelves);
    }

    public void RemoveShelf(LibraryShelf libraryShelf)
    {
        _shelves.Remove(libraryShelf);
    }    
}
