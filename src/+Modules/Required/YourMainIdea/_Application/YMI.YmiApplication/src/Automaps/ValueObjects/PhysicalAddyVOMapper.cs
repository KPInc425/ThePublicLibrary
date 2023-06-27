namespace YMI.YmiApplication.Automaps;
public class PhysicalAddyVOMapper : Profile
{
    public override string ProfileName
    {
        get { return "PhysicalAddyVO Map"; }
    }

    public PhysicalAddyVOMapper()
    {
        CreateMap<PhysicalAddyVO, PhysicalAddyVOViewModel>();
    }
}