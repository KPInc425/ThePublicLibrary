namespace TPL.Core.TestData.Entities;
public class AuthorTestData : ITestData {
    public readonly NameVO AuthorJohnWriterName = new("John", "Writer");
    public readonly NameVO AuthorSallyTyperName = new("Sally", "Typer");
    public readonly NameVO AuthorBishopKnightName = new("Bishop", "Knight");
    public readonly Author AuthorJohnWriter;
    public readonly Author AuthorSallyTyper;
    public readonly Author AuthorBishopKnight;
    public IEnumerable<Author> AllAuthors;

    public AuthorTestData() {
        AuthorJohnWriter = new(AuthorJohnWriterName);
        AuthorSallyTyper = new(AuthorSallyTyperName);
        AuthorBishopKnight = new(AuthorBishopKnightName);


        AllAuthors = new List<Author> {
            AuthorJohnWriter,
            AuthorSallyTyper,
            AuthorBishopKnight
        }
        .AsReadOnly();
    }
}
