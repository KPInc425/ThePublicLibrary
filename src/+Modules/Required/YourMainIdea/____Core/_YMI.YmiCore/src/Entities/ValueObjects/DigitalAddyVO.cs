namespace YMI.YmiCore.Entities;
[Owned]
public class DigitalAddyVO : ValueObject
{
    public DigitalAddyType Type { get; private set; }
    public long PhoneNumber { get; private set; }
    public string Description { get; private set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private DigitalAddyVO(){}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public DigitalAddyVO(DigitalAddyType type, long phoneNumber, string description)
    {
        Type = type;
        PhoneNumber = phoneNumber;
        Description = description;
    }
}
