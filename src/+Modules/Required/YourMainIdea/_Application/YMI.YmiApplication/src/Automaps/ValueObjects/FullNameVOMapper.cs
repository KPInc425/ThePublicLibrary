namespace YMI.YmiApplication.Automaps;
public class FullNameVOMapper : Profile
{
    public override string ProfileName
    {
        get { return "FullNameVO Map"; }
    }

    public FullNameVOMapper()
    {
        CreateMap<FullNameVO, FullNameVOViewModel>();
    }
}