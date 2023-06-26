namespace YMI.YmiCore.YmiTestData.Entities;
public static class AuthorYmiTestData {
    public static NameVO AuthorJohnWriterName = new("John", "Writer");
    public static NameVO AuthorSallyTyperName = new("Sally", "Typer");
    public static NameVO AuthorBishopKnightName = new("Bishop", "Knight");
    public static Author AuthorJohnWriter;
    public static Author AuthorSallyTyper;
    public static Author AuthorBishopKnight;
    public static IEnumerable<Author> AllAuthors;

    static AuthorYmiTestData() {
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
