namespace YMI.YmiApplication.Automaps;
public class VideoMapper : Profile
{
    public override string ProfileName
    {
        get { return "Video Map"; }
    }

    public VideoMapper()
    {
        CreateMap<Video, VideoViewModel>()
        .ReverseMap()
        ;
    }
}