namespace TPL.Application.Shared.Interfaces;

public partial interface IDataService {
    Task<BookViewModel> BookAddAsync(BookAddCmd cmd);
    Task<List<BookViewModel>> BooksGetAllAsync(BooksGetAllQry qry);
    Task<List<BookViewModel>> BooksFindAsync(BooksFindQry qry);
}