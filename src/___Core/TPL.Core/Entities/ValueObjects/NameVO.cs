﻿namespace TPL.Core.Entities;
[Owned]
public class NameVO : ValueObject
{
    public string FirstName { get; }
    public string MiddleName { get; }
    public string LastName { get; }
    public string NameSuffix { get; }
    private NameVO(){}
    public NameVO (string firstName, string middleName, string lastName, string nameSuffix) {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
        NameSuffix = nameSuffix;
    }
}
