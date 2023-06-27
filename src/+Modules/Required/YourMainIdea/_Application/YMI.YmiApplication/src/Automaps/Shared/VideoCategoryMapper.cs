namespace YMI.YmiApplication.Automaps;
public class VideoCategoryMapper : Profile
{
    public override string ProfileName
    {
        get { return "VideoCategory Map"; }
    }

    public VideoCategoryMapper()
    {
        CreateMap<VideoCategory, VideoCategoryViewModel>();
    }
}