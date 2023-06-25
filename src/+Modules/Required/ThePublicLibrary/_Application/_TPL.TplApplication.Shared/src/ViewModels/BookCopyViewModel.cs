namespace TPL.TplApplication.Shared.ViewModels;
public class BookCopyViewModel : BaseViewModelTracked<Guid>
{
    public BookViewModel Book { get; set; }
    public int CopySequence { get; set; }
    public BookCondition Condition { get; set; }

}
