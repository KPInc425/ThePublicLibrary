namespace TPL.Application.ViewModels;
public class IsbnVOViewModel
{
    public string Isbn { get; set; }

    public override string ToString()
    {
        return Isbn;
    }
}
