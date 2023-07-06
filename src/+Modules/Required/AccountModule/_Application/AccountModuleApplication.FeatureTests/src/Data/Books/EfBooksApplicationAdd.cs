namespace AccountModuleApplication.FeatureTests.Data.KnownAccounts;
public class EfKnownAccountApplicationAdd : BaseApplicationTestFixture
{
    [Fact]
    public async Task AddKnownAccount()
    {

        var result = await _dataService.KnownAccountAllAsync();
        result!.Count.Should().Be(0, "because we haven't added any books yet");

        /* var cmd = new KnownAccountAddCmd(KnownAccountTestData.KnownAccountAlfradoTheGreat);
        await _dataService.KnownAccountAddAsync(cmd);

        var qry = new KnownAccountsGetAllQry();
        result = (await _dataService.KnownAccountsGetAllAsync(qry));
        var resultFirst = result!.FirstOrDefault();
        var resultFirstCopy = resultFirst?.KnownAccountCopies.FirstOrDefault();

        result.Should().NotBeNull("because we just added a known account");         */
    }
}
