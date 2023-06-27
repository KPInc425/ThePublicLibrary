namespace YMI.YmiApplication.Automaps;
public class ActorMapper : Profile
{
    public override string ProfileName
    {
        get { return "Actor Map"; }
    }

    public ActorMapper()
    {
        CreateMap<Actor, ActorViewModel>();
    }
}