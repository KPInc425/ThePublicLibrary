namespace YmiCore.UnitTests;

public class StorageContainerTests
{
    [Fact]
    public void CanCreateStorageContainer()
    {
        // Given we have a storage container name, description, and slot count
        var _name = "Store 1";
        var _Description = "Nice Pockets";
        var _SlotCount = 100;
        // When we create a storage container
        var _storageContainer = new StorageContainer(_name, _Description, _SlotCount);
        // Then we have a storage container with name, description, and slot count
        _storageContainer.Should().NotBeNull();
        _storageContainer.Name.Should().Be(_name);
        _storageContainer.Description.Should().Be(_Description);
        _storageContainer.SlotCount.Should().Be(_SlotCount);
    }
    [Fact]
    public void CanViewStorageContainerInventory()
    {
        // Given we have a Player with a Storage Container with Items
        var playerData = PlayerTestData.TestPlayerWithItems;
        // When we view the Storage Container Inventory
        var storageContainerInventory = playerData.ViewItemsInStorage().ToList();
        // Then we can see the Items in the Storage Container
        var singleItemSearchResult = storageContainerInventory.Find(x => x.Name == StorageItemTestData.AlternateTestItem.Name);
        var manyItemSearchResult = storageContainerInventory.FindAll(x => x.Name == StorageItemTestData.TestItem.Name);
        storageContainerInventory.Should().NotBeNull();
        storageContainerInventory.Count().Should().Be(StorageItemTestData.ManyItems.Count() + 1);
        singleItemSearchResult.Should().NotBeNull();
        singleItemSearchResult.Name.Should().Be(StorageItemTestData.AlternateTestItem.Name);
        manyItemSearchResult.Should().NotBeNull();
        manyItemSearchResult.FirstOrDefault().Name.Should().Be(StorageItemTestData.TestItem.Name);
        manyItemSearchResult.Count().Should().Be(StorageItemTestData.ManyItems.Count());
    }

    [Fact]
    public void CanAddItemsToStorageContainer()
    {
        // Given we have a Player with a Storage Container with Items
        var playerData = PlayerTestData.TestPlayer;
        // And we have an item
        var itemData = StorageItemTestData.TestItem;
        // And we have many items
        var manyItemsData = StorageItemTestData.ManyItems;
        // When we Add an Item to the Players Inventory
        playerData.AddItemToStorage(itemData);
        // And when we add many items to the players inventory
        playerData.AddManyItemsToStorage(manyItemsData);
        // Then we can view the Item in the Players Inventory
        playerData.ViewItemsInStorage().Count().Should().Be(StorageItemTestData.ManyItems.Count() + 1);
    }
    [Fact]
    public void CanRemoveItemsFromStorageContainer()
    {
        // Given we have a Player with a Storage Container with Items
        var playerData = PlayerTestData.TestPlayerWithItems;
        // And we have an item name
        var itemData = StorageItemTestData.AlternateTestItem;
        // And we have many item names
        var manyItemsData = StorageItemTestData.ManyItems;
        // When we Remove an Item from the Players Inventory
        playerData.RemoveItemFromStorage(itemData).Should().BeTrue();
        // And when we remove many items to the players inventory
        playerData.RemoveManyItemsFromStorage(manyItemsData).Should().BeTrue();
        // Then we can view the the remaing items in the Players Inventory
        playerData.ViewItemsInStorage().Count().Should().Be(0);

    }
    
    [Fact]
    public void OverflowExtraItemsToLostItemPool()
    {
        // Given we have a Game with a Player with a Storage Container with Items
        var playerData = new Player(PlayerTestData.TestPlayer.Name);
        var gameData = new Game(playerData);
        // When we add 101 items to the players inventory
        var overFlowItems = gameData.Player.AddManyItemsToStorage(StorageItemTestData.OverFlowItems);
        // And we add overflow items to games lost items pool
        gameData.AddItemToLostItemsStorage(overFlowItems.FirstOrDefault());
        gameData.AddManyItemsToLostItemsStorage(StorageItemTestData.OverFlowItems2);
        // Then we can see 100 items in players inventory
        gameData.Player.ViewItemsInStorage().Count().Should().Be(100);
        // And then we can see 1 item in games lost items inventory
        gameData.ViewLostItemsInStorage().Count().Should().Be(StorageItemTestData.OverFlowItems2.Count() + 1);
    }   
}

