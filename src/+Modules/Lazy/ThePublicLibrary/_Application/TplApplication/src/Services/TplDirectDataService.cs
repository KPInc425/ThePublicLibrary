namespace TplApplication.Services;
public partial class TplDirectDataService : ITplDataService
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    public TplDirectDataService(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }
}