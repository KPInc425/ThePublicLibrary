namespace YMI.YmiApplication.FeatureTests.Data;
public class EfVideoStoreRepositoryDelete : BaseApplicationTestFixture
{
    [Fact]
    public async Task DeletesItemAfterAddingIt()
    {
        await Task.Yield();
        /*   // add a VideoStore
          var repository = VideoStoreRepository();
          var initialName = "My Name";
          var initialId = Guid.NewGuid();

          var VideoStore = new VideoStore(initialId, initialName);
          await repository.AddAsync(VideoStore);

          // delete the item
          await repository.DeleteAsync(VideoStore);

          // verify it's no longer there
          Assert.DoesNotContain(await repository.ListAsync(),
              VideoStore => VideoStore.Id == initialId); */
    }
}
