namespace AccountModuleApplication.Services;
public partial class KnownAccountDirectDataService : IAccountModuleDataService
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    public KnownAccountDirectDataService(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }
}