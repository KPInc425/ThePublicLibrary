namespace TPL.API.PrimaryApi.Controllers;

public class BooksController : BaseController
{
    public BooksController(IMediator mediator, IMapper mapper) : base(mediator, mapper) { }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var qry = new BooksGetAllQry();
        var result = await _mediator.Send(qry);
        var response = _mapper.Map<IEnumerable<BookViewModel>>(result);
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> FindByTitle([FromQuery] string searchFor)
    {
        var qry = new BooksFindByTitleQry(searchFor);
        var result = _mapper.Map<IEnumerable<BookViewModel>>(await _mediator.Send(qry));
        return Ok(result);
    }
}
