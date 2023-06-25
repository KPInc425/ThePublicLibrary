namespace TPL.TplApplication.Automaps;
public class PhysicalAddressVOMapper : Profile
{
    public override string ProfileName
    {
        get { return "PhysicalAddressVO Map"; }
    }

    public PhysicalAddressVOMapper()
    {
        CreateMap<PhysicalAddressVO, PhysicalAddressVOViewModel>();
    }
}