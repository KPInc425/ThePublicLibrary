namespace TPL.Core.Entities;

[Owned]
public class IsbnVO : ValueObject
{
    public string Isbn { get; }

    private IsbnVO() { }
    
    public IsbnVO(string isbn)
    {
        Isbn = isbn;
    }
}
