namespace TPL.Core.Entities;

[Owned]
public class IsbnVO : ValueObject
{
    [IndexColumn("Index_RegistrationNumber", IsUnique=true)]
    public string Isbn { get; private set; }

    private IsbnVO() { }

    public IsbnVO(string isbn)
    {
        Isbn = isbn;
    }

    public override string ToString()
    {
        return Isbn;
    }
}
