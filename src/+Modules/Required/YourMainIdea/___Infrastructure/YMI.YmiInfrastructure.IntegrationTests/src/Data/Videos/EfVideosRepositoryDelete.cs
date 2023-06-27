namespace YMI.YmiInfrastructure.IntegrationTests.Data;
public class EfVideoRepositoryDelete : BaseTestFixture
{
    [Fact]
    public async Task DeletesItemAfterAddingIt()
    {
      /*   // add a Video
        var repository = VideoRepository();
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
