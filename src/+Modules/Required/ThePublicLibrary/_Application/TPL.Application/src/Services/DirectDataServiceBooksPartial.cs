namespace TPL.Application.Services;
public partial class DirectDataService
{
    public async Task<BookViewModel> BookAddAsync(BookAddCmd cmd)
    {
        return _mapper.Map<BookViewModel>(await _mediator.Send(cmd));
    }
    public async Task<List<BookViewModel>> BooksGetAllAsync(BooksGetAllQry qry)
    {
        return _mapper.Map<List<BookViewModel>>(await _mediator.Send(qry));
    }
}
