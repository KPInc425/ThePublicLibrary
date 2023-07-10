namespace YmiCore.Entities;
public class VideoStore
{
    public string StoreName { get; private set; }
    public string AddressLine1 { get; private set; }
    public VideoStore(string storeName, string addressLine1)
    {
        StoreName = Guard.Against.NullOrEmpty(storeName, "because store name is required");
        AddressLine1 = Guard.Against.NullOrEmpty(addressLine1, "because address is required");        
    }
}
