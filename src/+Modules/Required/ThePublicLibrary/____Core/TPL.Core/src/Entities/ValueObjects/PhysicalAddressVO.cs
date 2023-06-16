namespace TPL.Core.Entities;
[Owned]
public class PhysicalAddressVO : ValueObject
{
    public string Street1 { get; init; }
    public string Street2 { get; init; }
    public string City { get; init; }
    public string StateProvince { get; init; }
    public string PostalCode { get; init; }
    public string Country { get; init; }
    private PhysicalAddressVO(){}
    public PhysicalAddressVO(string street1, string street2, string city, string stateProvince, string postalCode, string country)
    {
        Street1 = street1;
        Street2 = street2;
        City = city;
        StateProvince = stateProvince;
        PostalCode = postalCode;
        Country = country;
    }
}
