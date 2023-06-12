namespace TPL.PrimaryApi.Controllers;

public class BooksController : BaseController
{
    public BooksController(IMediator mediator, IMapper mapper) : base(mediator, mapper) { }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var qry = new BooksGetAllQuery();
        var result = _mapper.Map<IEnumerable<BookViewModel>>(await _mediator.Send(qry));
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> FindByTitle([FromQuery] string searchFor)
    {
        var qry = new BooksFindByTitleQuery(searchFor);
        var result = _mapper.Map<IEnumerable<BookViewModel>>(await _mediator.Send(qry));
        return Ok(result);
    }
}
