namespace YMI.API.YmiApi.Controllers;

public class VideosController : BaseController
{
    public VideosController(IMediator mediator, IMapper mapper) : base(mediator, mapper) { }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var qry = new VideosGetAllQry();
        var result = await _mediator.Send(qry);
        var response = _mapper.Map<IEnumerable<VideoViewModel>>(result);
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> FindByTitle([FromQuery] string searchFor)
    {
        var qry = new VideosFindByTitleQry(searchFor);
        var result = _mapper.Map<IEnumerable<VideoViewModel>>(await _mediator.Send(qry));
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> Find([FromQuery] string titleSearch, [FromQuery] IEnumerable<string> actorSearch, [FromQuery] IEnumerable<string> categorySearch, [FromQuery] IEnumerable<string> conditionSearch)
    {
        var qry = new VideosFindQry(titleSearch, actorSearch, categorySearch, conditionSearch);
        var result = _mapper.Map<IEnumerable<VideoViewModel>>(await _mediator.Send(qry));
        return Ok(result);
    }
}
