namespace YMI.YmiApplication.Shared.ViewModels;
public class VideoViewModel : BaseViewModelTracked<Guid>
{
    public IsbnVOViewModel Isbn { get; set; }
    public string Title { get; set; }
    public int PublicationYear { get; set; }
    public int PageCount { get; set; }

    public List<Actor> Actors  { get; set; } = new();
    
    public List<VideoCategoryViewModel> VideoCategories  { get; set; } = new();
    
    public List<VideoCopyViewModel> VideoCopies  { get; set; } = new();
    

}
