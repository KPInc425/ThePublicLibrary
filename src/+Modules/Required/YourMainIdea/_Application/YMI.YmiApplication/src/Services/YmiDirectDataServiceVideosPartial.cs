namespace YMI.YmiApplication.Services;
public partial class YmiDirectDataService
{
    public async Task<VideoViewModel> VideoAddAsync(VideoAddCmd cmd)
    {
        return _mapper.Map<VideoViewModel>(await _mediator.Send(cmd));
    }
    public async Task<List<VideoViewModel>> VideosGetAllAsync(VideosGetAllQry qry)
    {
        return _mapper.Map<List<VideoViewModel>>(await _mediator.Send(qry));
    }
    public async Task<List<VideoViewModel>> VideosFindAsync(VideosFindQry qry)
    {
        return _mapper.Map<List<VideoViewModel>>(await _mediator.Send(qry));
    }
}
