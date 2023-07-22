namespace YmiCore.TestData.Entities;
public static class StorageItemTestData
{
    public static StorageItem TestItem;
    public static StorageItem AlternateTestItem;
    public static IEnumerable<StorageItem> ManyItems;
    private static List<StorageItem> _overFlowItems = new();
    public static IEnumerable<StorageItem> OverFlowItems => _overFlowItems.AsReadOnly();
    private static List<StorageItem> _overFlowItems2 = new();
    public static IEnumerable<StorageItem> OverFlowItems2 => _overFlowItems2.AsReadOnly();

    static StorageItemTestData()
    {
        var _name = "Item Name";
        var _description = "Item Description";
        var _price = 100.00f;
        var _imageUrl = "https://www.KPInc425.com";

        TestItem = new StorageItem(_name, _description, _price, ItemTypes.Product, _imageUrl);
        AlternateTestItem = new StorageItem("Herbage", "Something Strong!", 45.00f, ItemTypes.Product, "https://www.WhiteWillow.com");

        ManyItems = new List<StorageItem> {
            TestItem,
            TestItem,
            TestItem,
            TestItem,
            TestItem
        };

        for (int i = 0; i < 101; i++)
        {
            _overFlowItems.Add(TestItem);
        }
        for (int i = 0; i < 150; i++)
        {
            _overFlowItems2.Add(TestItem);
        }

    }
}
