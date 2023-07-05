namespace AccountModuleApplication.Services;
public partial class AccountModuleDirectDataService //: IAccountModuleDirectDataService
{
    protected readonly IMediator _mediator;
    protected readonly IMapper _mapper;
    public AccountModuleDirectDataService(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }
}