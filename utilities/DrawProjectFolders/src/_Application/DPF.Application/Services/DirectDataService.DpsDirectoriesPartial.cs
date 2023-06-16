namespace Dpf.Application.Services;
public partial class DirectDataService
{
    public async Task<DpfDirectoryViewModel> DpfDirectoryAddAsync(DpfDirectoryAddCommand cmd)
    {
        return _mapper.Map<DpfDirectoryViewModel>(await _mediator.Send(cmd));
    }
    public async Task<List<DpfDirectoryViewModel>> DpfDirectoriesGetAllAsync(DpfDirectoriesGetAllQuery qry)
    {
        return _mapper.Map<List<DpfDirectoryViewModel>>(await _mediator.Send(qry));
    }
}
