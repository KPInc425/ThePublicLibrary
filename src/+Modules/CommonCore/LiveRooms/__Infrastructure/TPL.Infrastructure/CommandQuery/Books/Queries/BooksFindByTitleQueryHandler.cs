namespace TPL.Infrastructure.CommandQuery;

public class BooksFindByTitleQueryHandler : IRequestHandler<BooksFindByTitleQuery, List<Book>>
{
    private readonly IRepository<Book> _repository;
    public BooksFindByTitleQueryHandler(IRepository<Book> repository)
    {
        _repository = repository;
    }
    public async Task<List<Book>> Handle(BooksFindByTitleQuery qry, CancellationToken cancellationToken)
    {
        var booksFindByTitleSpec = new BooksFindByTitleSpec(qry.SearchFor);
        return await _repository.ListAsync(booksFindByTitleSpec, cancellationToken);
    }
}