namespace YMI.YmiApplication.Automaps;
public class DigitalAddyVOMapper : Profile
{
    public override string ProfileName
    {
        get { return "DigitalAddyVO Map"; }
    }

    public DigitalAddyVOMapper()
    {
        CreateMap<DigitalAddyVO, DigitalAddyVOViewModel>();
    }
}