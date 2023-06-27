namespace YMI.YmiApplication.Automaps;
public class VideoStoreMapper : Profile
{
    public override string ProfileName
    {
        get { return "VideoStore Map"; }
    }

    public VideoStoreMapper()
    {
        CreateMap<VideoStore, VideoStoreViewModel>();
    }
}