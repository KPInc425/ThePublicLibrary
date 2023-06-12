namespace TPL.Core.Entities.TestData;
public class BookTestData : ITestData {
    public readonly string TheWildSidePoorConditionISBN = ISBNx3;
    public readonly string TheWildSideGoodConditionTitle = "The Wild Side";
    public readonly Book TheWildSidePoorCondition;
    
    public readonly string TheWildSideGoodConditionISBN = ISBNx3;
    public readonly string TheWildSidePoorConditionTitle = "The Wild Side";
    public readonly Book TheWildSideGoodCondition;
    
    public readonly string JumpingForJaxISBN = "978-0-00-000000-3";
    public readonly string JumpingForJaxTitle = "Jumping for Jax";
    public readonly Book JumpingForJax;
    
    public readonly string JuniperRisingISBN = "978-0-00-000000-4";
    public readonly string JuniperRisingTitle = "Juniper Rising";
    public readonly Book JuniperRising;
    
    public readonly string AlfradoTheGreatISBN = "978-0-00-000000-5";
    public readonly string AlfradoTheGreatTitle = "Alfrado the Great";
    public readonly Book AlfradoTheGreat;

    public static  string ISBNx3 = "978-0-00-000000-6";
    
    public readonly IEnumerable<Book> AllBooks;

    public BookTestData() {
        TheWildSidePoorCondition = new Book(TheWildSidePoorConditionISBN, TheWildSidePoorConditionTitle, BookCondition.Poor);
        TheWildSideGoodCondition = new Book(TheWildSideGoodConditionISBN, TheWildSideGoodConditionTitle, BookCondition.Good);
        JumpingForJax = new Book(JumpingForJaxISBN, JumpingForJaxTitle, BookCondition.Good);
        JuniperRising = new Book(JuniperRisingISBN, JuniperRisingTitle, BookCondition.Good);
        AlfradoTheGreat = new Book(AlfradoTheGreatISBN, AlfradoTheGreatTitle, BookCondition.Good);        
        
        AllBooks = new List<Book> {
            TheWildSidePoorCondition,
            TheWildSideGoodCondition,
            JumpingForJax,
            JuniperRising,
            AlfradoTheGreat
        };
    }
}
