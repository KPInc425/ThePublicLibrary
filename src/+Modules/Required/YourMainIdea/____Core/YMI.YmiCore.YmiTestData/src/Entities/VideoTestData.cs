namespace YMI.YmiCore.YmiTestData.Entities;
public static class VideoYmiTestData
{
    public static Video VideoTheWildSide;
    public static Video VideoJumpingForJax;
    public static Video VideoJuniperRising;
    public static Video VideoAlfradoTheGreat;
    public static Video VideoManyCopies;
    public static Video VideoNoCopies;
    public static Video VideoWithCategories;
    public static Video VideoOfThreeActors;
    public static Video VideoOfFantasy;

    public static VideoCategory VideoCategoryFiction;
    public static VideoCategory VideoCategoryNonFiction;
    public static VideoCategory VideoCategoryScify;
    public static VideoCategory VideoCategoryFantasy;

    public static IEnumerable<Video> AllVideos;

    static VideoYmiTestData()
    {
        VideoCategoryFiction = new("Fiction");
        VideoCategoryNonFiction = new("Non-Fiction");
        VideoCategoryScify = new("Scify");
        VideoCategoryFantasy = new("Fantasy");

        VideoTheWildSide = new(new("978-0-00-000000-6"), new List<Actor>() { ActorYmiTestData.ActorJohnWriter }, null, null, "The Wild Side", 1982, 100);
        VideoTheWildSide.AddVideoCopy(VideoCondition.Poor);
        VideoTheWildSide.AddVideoCopy(VideoCondition.Good);

        VideoJumpingForJax = new(new("978-0-00-000000-7"), new List<Actor>() { ActorYmiTestData.ActorSallyTyper }, null, null, "Jumping for Jax", 1983, 200);
        VideoJumpingForJax.AddVideoCopy(VideoCondition.Good);

        VideoJuniperRising = new(new("978-0-00-000000-8"), new List<Actor>() { ActorYmiTestData.ActorBishopKnight }, null, null, "Juniper Rising", 1984, 300);
        VideoJuniperRising.AddVideoCopy(VideoCondition.Good);

        VideoAlfradoTheGreat = new(new("978-0-00-000000-9"), new List<Actor>() { ActorYmiTestData.ActorJohnWriter }, null, null, "Alfrado The Great", 1985, 400);
        VideoAlfradoTheGreat.AddVideoCopy(VideoCondition.Good);

        VideoNoCopies = new(new("978-0-00-000441-1"), new List<Actor>() { ActorYmiTestData.ActorSallyTyper }, null, null, "Video No Copies", 1981, 110);

        VideoManyCopies = new(new("978-0-00-000001-1"), new List<Actor>() { ActorYmiTestData.ActorSallyTyper }, null, null, "Video Many Copies", 1981, 110);
        VideoManyCopies.AddVideoCopy(VideoCondition.Good);
        VideoManyCopies.AddVideoCopy(VideoCondition.Good);
        VideoManyCopies.AddVideoCopy(VideoCondition.Good);
        VideoManyCopies.AddVideoCopy(VideoCondition.Good);
        VideoManyCopies.AddVideoCopy(VideoCondition.Good);
        VideoManyCopies.AddVideoCopy(VideoCondition.Good);
        VideoManyCopies.AddVideoCopy(VideoCondition.Good);

        VideoOfThreeActors = new(new("978-0-00-000331-2"), new List<Actor> { ActorYmiTestData.ActorBishopKnight, ActorYmiTestData.ActorJohnWriter, ActorYmiTestData.ActorSallyTyper }, null, null, "Video of Three Actors", 1981, 120);

        VideoWithCategories = new(new("978-0-00-000131-1"), new List<Actor> { ActorYmiTestData.ActorSallyTyper }, new List<VideoCategory> { VideoCategoryFantasy, VideoCategoryFiction }, null, "Video With Categories", 1981, 110);
        VideoWithCategories.AddVideoCopy(VideoCondition.Good);
        VideoWithCategories.AddVideoCopy(VideoCondition.Fair);
        VideoWithCategories.AddVideoCopy(VideoCondition.Poor);
        
        VideoOfFantasy = new(new("978-0-00-000214-6"), new List<Actor> { ActorYmiTestData.ActorSallyTyper }, new List<VideoCategory> { VideoCategoryFantasy }, null, "Video Of Fantasy", 1981, 110);


        AllVideos = new List<Video> {
            VideoTheWildSide,
            VideoJumpingForJax,
            VideoJuniperRising,
            VideoAlfradoTheGreat,
            VideoManyCopies,
            VideoNoCopies,
            VideoWithCategories,
            VideoOfThreeActors,
            VideoOfFantasy
        };
    }
}
