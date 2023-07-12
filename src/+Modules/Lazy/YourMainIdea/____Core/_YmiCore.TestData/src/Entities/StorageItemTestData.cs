namespace YmiCore.TestData.Entities;
public static class StorageItemTestData
{
    public static StorageItem TestItem;
    public static StorageItem AlternateTestItem;

    public static IEnumerable<StorageItem> ManyItems;

    static StorageItemTestData()
    {
        var _name = "Item Name";
        var _description = "Item Description";
        var _price = 100.00f;
        var _imageUrl = "https://www.KPInc425.com";
        // When I create a StorageItem
        TestItem = new StorageItem(_name, _description, _price, ItemTypes.Product, _imageUrl);
        AlternateTestItem = new StorageItem("Herbage", "Something Strong!", 45.00f, ItemTypes.Product, "https://www.WhiteWillow.com");

        ManyItems = new List<StorageItem> {
            TestItem,
            TestItem,
            TestItem,
            TestItem,
            TestItem
        };
    }
}
