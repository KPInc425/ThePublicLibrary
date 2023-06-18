namespace TPL.Core.Entities;

public class BookAr : BaseEntityTracked<Guid>
{
    public string Isbn { get; set; }
    public string Title { get; set; }
    public int PublicationYear { get; set; }
    public int PageCount { get; set; }
}
