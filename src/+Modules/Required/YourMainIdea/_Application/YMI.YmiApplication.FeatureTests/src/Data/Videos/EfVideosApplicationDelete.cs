namespace YMI.YmiApplication.FeatureTests.Data;
public class EfVideoApplicationDelete : BaseApplicationTestFixture
{
    [Fact]
    public async Task DeletesItemAfterAddingIt()
    {
        await Task.Yield();
        /*   // add a Video
          var repository = VideoApplication();
          var initialName = "My Name";
          var initialId = Guid.NewGuid();

          var Video = new Video(initialId, initialName);
          await repository.AddAsync(Video);

          // delete the item
          await repository.DeleteAsync(Video);

          // verify it's no longer there
          Assert.DoesNotContain(await repository.ListAsync(),
              Video => Video.Id == initialId); */
    }
}
