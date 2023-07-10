namespace YmiCore.TestData.Entities;

public class CityTestData
{
    public static City TestCity;

    public static IEnumerable<City> AllCities;

    static CityTestData()
    {
        var regionA = new LocationRegion("RegionA");
        TestCity = new City(regionA, "NewJack City");

        AllCities = new List<City> {
            TestCity,
        };
    }

}
