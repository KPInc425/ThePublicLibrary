namespace YmiCore.Entities;

public class StorageItem : BaseEntity<Guid>
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public float Price { get; private set; }
    public ItemTypes ItemType { get; private set; }
    public string ImageUrl { get; private set; }

    private StorageItem() { }

    public StorageItem(string name, string description, float price, ItemTypes itemType, string imageUrl)
    {
        Name = Guard.Against.NullOrEmpty(name, "Because Name is required");
        Description = Guard.Against.NullOrEmpty(description, "Because Description is required");
        Price = Guard.Against.Null(price, "Because Price is required");
        ItemType = Guard.Against.Null(itemType, "Because ItemType is required");
        ImageUrl = Guard.Against.NullOrEmpty(imageUrl, "Because ImageUrl is required");
    }
}

