namespace YMI.YmiApplication.Automaps;
public class VideoCopyMapper : Profile
{
    public override string ProfileName
    {
        get { return "VideoCopy Map"; }
    }

    public VideoCopyMapper()
    {
        CreateMap<VideoCopy, VideoCopyViewModel>()
        .ForMember(rs => rs.Video, rss => rss.Ignore())
        ;
    }
}