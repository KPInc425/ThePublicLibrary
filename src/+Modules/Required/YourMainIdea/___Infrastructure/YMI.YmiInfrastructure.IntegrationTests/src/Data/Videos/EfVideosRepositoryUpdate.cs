namespace YMI.YmiInfrastructure.IntegrationTests.Data;
public class EfVideoRepositoryUpdate : BaseTestFixture
{
    [Fact]
    public async Task UpdatesItemAfterAddingIt()
    {
        /* // add a Video
        var repository = VideoRepository();
        var initialName = "My Name";
        var initialId = Guid.NewGuid();

        var Video = new Video(initialId, initialName);

        await repository.AddAsync(Video);
        await repository.UpdateAsync(Video);

        // detach the item so we get a different instance
        _dbContext.Entry(Video).State = EntityState.Detached;

        // fetch the item and update its title
        var newVideo = (await repository.ListAsync())
            .FirstOrDefault(rs => rs.Id == initialId);

        Assert.NotNull(newVideo);
        Assert.NotSame(Video, newVideo);
        var newName = "abc123";
        newVideo.UpdateName(newName);

        // Update the item
        await repository.UpdateAsync(newVideo);

        // Fetch the updated item
        var updatedItem = (await repository.ListAsync())
            .FirstOrDefault(rs => rs.Id == initialId);

        Assert.NotNull(updatedItem);
        Assert.NotEqual(Video.Name, updatedItem.Name);
        Assert.Equal(newVideo.Id, updatedItem.Id); */
    }
}
