namespace YmiCore.Entities;
public class GameInstance : BaseEntityTracked<Guid>, IAggregateRoot
{
    public string Title { get; private set; }
    public string CurrentCity { get; private set; }
    public string CurrentDay { get; private set; }
    public int MaxDays { get; private set; }
    public string TimeOfDay { get; private set; }
    public string StartLocaiton { get; private set; }
}