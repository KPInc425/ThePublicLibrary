namespace YmiCore.Entities;
public class Player : BaseEntityTracked<Guid>, IAggregateRoot
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public string Bio { get; private set; }
    public UpbringingTypes UpbringingType { get; private set; }


    private Player() { }
    public Player(string name, string description = "The most B-E-A-utiful!", string bio = "This person bio\'s!", UpbringingTypes upbringingType = UpbringingTypes.SuburbanKid)
    {
        Name = Guard.Against.NullOrEmpty(name, "Because Name cannot be empty");
        Description = description;
        Bio = bio;
        UpbringingType = upbringingType;
    }
    public override string ToString()
    {
        return Name.ToString();
    }
}
