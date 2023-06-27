namespace YMI.YmiInfrastructure.IntegrationTests.Data.Videos;
public class EfVideoRepositoryAdd : BaseTestFixture
{
    [Fact]
    public async Task AddsVideoSetsId()
    {
        var repository = VideoRepository();
        var Video = VideoYmiTestData.VideoAlfradoTheGreat;

        await repository.AddAsync(Video);

        var newVideo = (await repository.ListAsync())
                        .FirstOrDefault();

        Assert.NotNull(newVideo?.Id);
    }
}
