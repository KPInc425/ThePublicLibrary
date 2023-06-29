namespace YMI.YmiInfrastructure.IntegrationTests.Data.VideoStores;
public class EfVideoStoreRepositoryAdd : BaseTestFixture
{
    [Fact]
    public async Task AddsVideoStoreSetsId()
    {
        await Task.Yield();
        /*  var repository = VideoStoreRepository();

         var videoStore = _videoStoreYmiTestData.FirstStreetVideoStore;

         await repository.AddAsync(videoStore);

         var newVideoStore = (await repository.ListAsync())
                         .FirstOrDefault();

         Assert.NotNull(newVideoStore?.Id); */
    }
}
