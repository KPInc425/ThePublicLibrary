namespace TPL.Core.Entities;
[Owned]
public class NameVO : ValueObject
{
    public string FirstName { get; }
    public string MiddleName { get; }
    public string LastName { get; }
    public string NameSuffix { get; }
    private NameVO() { }
    public NameVO(string firstName, string lastName, string middleName = "", string nameSuffix = "")
    {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
        NameSuffix = nameSuffix;
    }
}
