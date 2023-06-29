namespace YMI.YmiApplication.Shared.Interfaces;

public partial interface IYmiDataService {
    Task<VideoViewModel?> VideoAddAsync(VideoAddCmd cmd);
    Task<List<VideoViewModel>?> VideosGetAllAsync(VideosGetAllQry qry);
    Task<List<VideoViewModel>?> VideosFindAsync(VideosFindQry qry);
}