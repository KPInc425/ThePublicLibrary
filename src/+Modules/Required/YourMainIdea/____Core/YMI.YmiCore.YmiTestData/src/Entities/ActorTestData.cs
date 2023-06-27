namespace YMI.YmiCore.YmiTestData.Entities;
public static class ActorYmiTestData {
    public static FullNameVO ActorJohnWriterName = new("John", "Writer");
    public static FullNameVO ActorSallyTyperName = new("Sally", "Typer");
    public static FullNameVO ActorBishopKnightName = new("Bishop", "Knight");
    public static Actor ActorJohnWriter;
    public static Actor ActorSallyTyper;
    public static Actor ActorBishopKnight;
    public static IEnumerable<Actor> AllActors;

    static ActorYmiTestData() {
        ActorJohnWriter = new(ActorJohnWriterName);
        ActorSallyTyper = new(ActorSallyTyperName);
        ActorBishopKnight = new(ActorBishopKnightName);


        AllActors = new List<Actor> {
            ActorJohnWriter,
            ActorSallyTyper,
            ActorBishopKnight
        }
        .AsReadOnly();
    }
}
