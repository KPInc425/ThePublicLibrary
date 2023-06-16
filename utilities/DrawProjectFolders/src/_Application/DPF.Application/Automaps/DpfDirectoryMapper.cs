namespace Dpf.Application.Automaps;
public class DpfDirectoryMapper : Profile
{
    public override string ProfileName
    {
        get { return "Directory Map"; }
    }

    public DpfDirectoryMapper()
    {
        CreateMap<DpfDirectory, DpfDirectoryViewModel>()
            .ReverseMap();
    }
}