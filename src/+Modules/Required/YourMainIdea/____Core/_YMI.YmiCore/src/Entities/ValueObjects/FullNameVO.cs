namespace YMI.YmiCore.Entities;
[Owned]
public class FullNameVO : ValueObject
{
    public string FirstName { get; }
    public string MiddleName { get; }
    public string LastName { get; }
    public string NameSuffix { get; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private FullNameVO() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public FullNameVO(string firstName, string lastName, string middleName = "", string nameSuffix = "")
    {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
        NameSuffix = nameSuffix;
    }
}
