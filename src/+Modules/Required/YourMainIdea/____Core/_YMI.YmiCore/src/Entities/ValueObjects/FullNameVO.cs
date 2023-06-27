namespace YMI.YmiCore.Entities;
[Owned]
public class FullNameVO : ValueObject
{
    public string FirstName { get; }
    public string MiddleName { get; }
    public string LastName { get; }
    public string NameSuffix { get; }
    private FullNameVO() { }
    public FullNameVO(string firstName, string lastName, string middleName = "", string nameSuffix = "")
    {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
        NameSuffix = nameSuffix;
    }
}
