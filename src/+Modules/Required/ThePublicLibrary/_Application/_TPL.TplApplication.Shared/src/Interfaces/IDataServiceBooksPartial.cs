namespace TPL.TplApplication.Shared.Interfaces;

public partial interface ITplDataService {
    Task<BookViewModel> BookAddAsync(BookAddCmd cmd);
    Task<List<BookViewModel>> BooksGetAllAsync(BooksGetAllQry qry);
    Task<List<BookViewModel>> BooksFindAsync(BooksFindQry qry);
}