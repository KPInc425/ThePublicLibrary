namespace Dpf.Application.Services;
public partial class DirectDataService : IDataService
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    public DirectDataService(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }
}