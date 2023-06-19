namespace TPL.Application.Shared.Interfaces;

public partial interface IDataService {
    Task<BookViewModel> BookAddAsync(BookAddCommand cmd);
    Task<List<BookViewModel>> BooksGetAllAsync(BooksGetAllQuery qry);
}