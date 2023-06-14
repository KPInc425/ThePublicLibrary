namespace TPL.Infrastructure.CommandQuery;

public class BooksGetAllQueryHandler : IRequestHandler<BooksGetAllQuery, List<Book>>
{
    private readonly IRepository<Book> _repository;
    public BooksGetAllQueryHandler(IRepository<Book> repository)
    {
        _repository = repository;
    }
    public async Task<List<Book>> Handle(BooksGetAllQuery qry, CancellationToken cancellationToken)
    {
        return await _repository.ListAsync(cancellationToken);
    }
}