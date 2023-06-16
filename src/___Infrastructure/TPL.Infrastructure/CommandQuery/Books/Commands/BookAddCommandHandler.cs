using System.ComponentModel;
namespace TPL.Infrastructure.CommandQuery;
public class BookAddCommandHandler : IRequestHandler<BookAddCommand, Book>
{
    private readonly IRepository<Book> _repository;
    public BookAddCommandHandler(IRepository<Book> repository)
    {
        _repository = repository;
    }
    public async Task<Book> Handle(BookAddCommand request, CancellationToken cancellationToken)
    {
        var book = new Book(new(request.Isbn), request.Authors, request.BookCopies, request.Title, request.PublicationYear, request.PageCount);
        return await _repository.AddAsync(book, cancellationToken);
    }
}
