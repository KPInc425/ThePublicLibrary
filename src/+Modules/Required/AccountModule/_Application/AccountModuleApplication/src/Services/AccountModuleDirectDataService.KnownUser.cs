namespace AccountModuleApplication.Shared.Interfaces;

public partial interface IDataServiceKnownUserPartial
{
    public async Task<KnownUserViewModel> KnownUserGet()
    {
        var cmd = new KnownUserGet();
        return _mapper.Map<BookViewModel>(await _mediator.Send(cmd));
    }
    public async Task<KnownUserViewModel> KnownUserUpdateAccount(KnownUserUpdateAccountRequest request)
    {
        return _mapper.Map<BookViewModel>(await _mediator.Send(cmd));
    }
    
    
    
}