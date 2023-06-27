namespace YMI.YmiInfrastructure.IntegrationTests.Data;
public class EfVideoStoreRepositoryUpdate : BaseTestFixture
{
    [Fact]
    public async Task UpdatesItemAfterAddingIt()
    {
        /* // add a VideoStore
        var repository = VideoStoreRepository();
        var initialName = "My Name";
        var initialId = Guid.NewGuid();

        var VideoStore = new VideoStore(initialId, initialName);

        await repository.AddAsync(VideoStore);
        await repository.UpdateAsync(VideoStore);

        // detach the item so we get a different instance
        _dbContext.Entry(VideoStore).State = EntityState.Detached;

        // fetch the item and update its title
        var newVideoStore = (await repository.ListAsync())
            .FirstOrDefault(rs => rs.Id == initialId);

        Assert.NotNull(newVideoStore);
        Assert.NotSame(VideoStore, newVideoStore);
        var newName = "abc123";
        newVideoStore.UpdateName(newName);

        // Update the item
        await repository.UpdateAsync(newVideoStore);

        // Fetch the updated item
        var updatedItem = (await repository.ListAsync())
            .FirstOrDefault(rs => rs.Id == initialId);

        Assert.NotNull(updatedItem);
        Assert.NotEqual(VideoStore.Name, updatedItem.Name);
        Assert.Equal(newVideoStore.Id, updatedItem.Id); */
    }
}
