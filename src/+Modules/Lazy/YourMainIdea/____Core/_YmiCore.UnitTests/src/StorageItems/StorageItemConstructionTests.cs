namespace YmiCore.UnitTests;

public class StorageItemConstructorTests
{
    [Fact]
    public void CanCreateStorageItem()
    {
        // Given I have StorageItem Data (Name, Description, Price, Type, Ability, Image)
        var _name = "Item Name";
        var _description = "Item Description";
        var _price = 100.00f;
        // When I create a StorageItem
        var _storageItem = new StorageItem(_name, _description, _price, ItemTypes.Product, "https://www.KPInc425.com");
        // Then I have some storage container with data
        _storageItem.Should().NotBeNull();
    }
}
