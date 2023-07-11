namespace YmiCore.UnitTests;

public class StorageContainerTests
{
    [Fact]
    public void CanCreateStorageContainer()
    {
        // Given I have a storage container name, description, and slot count
        var _name = "Store 1";
        var _Description = "Nice Pockets";
        var _SlotCount = 100;
        // When I create a storage container
        var _storageContainer = new StorageContainer(_name, _Description, _SlotCount);
        // Then I have a storage container with name, description, and slot count
        _storageContainer.Should().NotBeNull();
        _storageContainer.Name.Should().Be(_name);
        _storageContainer.Description.Should().Be(_Description);
        _storageContainer.SlotCount.Should().Be(_SlotCount);
    }

    [Fact]
    public void CanAddItemsToStorageContainer()
    {
        // Given I have a Player
        var playerData = PlayerTestData.TestPlayer;
        // And I have an item
        var itemData = StorageItemTestData.TestItem;
        // And I have many items
        var manyItemsData = StorageItemTestData.ManyItems;
        // When I Add an Item to the Players Inventory
        playerData.AddItemToStorage(new StorageItem(itemData.Name, itemData.Description, itemData.Price, itemData.ItemType, itemData.ImageUrl));
        // And when I add many items to the players inventory
        playerData.AddManyItemsToStorage(manyItemsData);
        // Then I can view the Item in the Players Inventory
        playerData.ViewItemsInStorage().Count().Should().Be(StorageItemTestData.ManyItems.Count() + 1);
    }

    [Fact]
    public void CanSearchForItem()
    {
        // Given I have Inventory Data
        // And I am looking for a Item
        // When I search the inventory
        // Then I find 1 or more Items matching my search
    }  
}


// Given I have player and active game
// When I add 101 items to the players inventory
// Then I can see 100 items in players inventory
// And then I can see 1 item in games lost items inventory

// Given I have player and active game
// When I add 101 items to the players inventory
// Then I can see 100 items in players inventory
// And then I can see 1 item in games lost items inventory
