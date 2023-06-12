namespace TPL.Core.Entities;
public class PhysicalAddressVO : ValueObject
{
    public string Street { get; init; }
    public string City { get; init; }
    public string StateProvince { get; init; }
    public string PostalCode { get; init; }
    public string Country { get; init; }
    public PhysicalAddressVO(string street, string city, string stateProvince, string postalCode, string country)
    {
        Street = street;
        City = city;
        StateProvince = stateProvince;
        PostalCode = postalCode;
        Country = country;
    }
}
