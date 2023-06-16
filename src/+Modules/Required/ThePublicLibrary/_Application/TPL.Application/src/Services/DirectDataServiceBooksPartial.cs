namespace TPL.Application.Services;
public partial class DirectDataService
{
    public async Task<BookViewModel> BookAddAsync(BookAddCommand cmd)
    {
        return _mapper.Map<BookViewModel>(await _mediator.Send(cmd));
    }
    public async Task<List<BookViewModel>> BooksGetAllAsync(BooksGetAllQuery qry)
    {
        return _mapper.Map<List<BookViewModel>>(await _mediator.Send(qry));
    }
}
