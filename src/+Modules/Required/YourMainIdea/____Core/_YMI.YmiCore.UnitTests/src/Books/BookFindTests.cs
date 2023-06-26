
namespace YMI.YmiCore.UnitTests;

public class BookFindTests : BaseBooksTest
{
    public static TheoryData<int, string, IEnumerable<string>?, IEnumerable<string>?, IEnumerable<string>?, int?, int?> CanFindBookByTitleData =>
    new()
    {

            { BookYmiTestData.AllBooks.Count(rs=>rs.Title.Contains("a", StringComparison.OrdinalIgnoreCase)), "a", null, null, null, 0, int.MaxValue},
            { BookYmiTestData.AllBooks.Where(rs=>rs.Title.Contains("a", StringComparison.OrdinalIgnoreCase)).OrderBy(rs=>rs.Title).Skip(2).Take(2).Count(), "a", null, null, null, 2, 2},
            { BookYmiTestData.AllBooks.Where(rs=>rs.Title.Contains("a", StringComparison.OrdinalIgnoreCase)).OrderBy(rs=>rs.Title).Skip(1).Take(3).Count(), "a", null, null, null, 1, 3},
            { BookYmiTestData.AllBooks.Where(rs=>rs.Title.Contains("a", StringComparison.OrdinalIgnoreCase)).OrderBy(rs=>rs.Title).Skip(2).Take(2).Count(), "a", null, null, null, 2, 2},
            //{ BookYmiTestData.AllBooks.Where(rs=>rs.Title.Contains("a", StringComparison.OrdinalIgnoreCase)).OrderBy(rs=>rs.Title).Skip(3).Take(2).Count(), "a", null, null, null, 3, 2},
            { BookYmiTestData.AllBooks.Count(rs=>rs.Title.Contains("a", StringComparison.OrdinalIgnoreCase)), "a", null, null, null, null, null},
            { 2, "a", null, null, null, null, 2},
            //{ BookYmiTestData.AllBooks.Where(rs=>rs.Title.Contains("a", StringComparison.OrdinalIgnoreCase)).OrderBy(rs=>rs.Title).Skip(3).Take(1).Count(), "a", null, null, null, 3, 1},
            { 0, "a", null, null, null, 500, 1},


            { 1, BookYmiTestData.BookJumpingForJax.Title, null, null, null, 0, int.MaxValue},

            {1, BookYmiTestData.BookWithCategories.Title, BookYmiTestData.BookWithCategories.Authors!.Select(rs=>rs.Name.ToString()), null, null, 0, int.MaxValue},
            {1, BookYmiTestData.BookWithCategories.Title, BookYmiTestData.BookWithCategories.Authors!.Select(rs=>rs.Name.ToString().Substring(1,rs.Name.ToString().Length-1)), null, null, 0, int.MaxValue},

            { 1, BookYmiTestData.BookOfFantasy.Title, BookYmiTestData.BookOfFantasy.Authors!.Select(rs=>rs.Name.ToString()), BookYmiTestData.BookOfFantasy.BookCategories!.Select(rs=>rs.Title.ToString()), null, 0, int.MaxValue},
            { 1, BookYmiTestData.BookOfFantasy.Title, BookYmiTestData.BookOfFantasy.Authors!.Select(rs=>rs.Name.ToString()), BookYmiTestData.BookOfFantasy.BookCategories!.Select(rs=>rs.Title.ToString().Substring(1, rs.Title.ToString().Length-1)), null, 0, int.MaxValue},
            { 1, BookYmiTestData.BookOfFantasy.Title, BookYmiTestData.BookOfFantasy.Authors!.Select(rs=>rs.Name.ToString()), new List<string> {"fan"}, null, 0, int.MaxValue},

            {1, BookYmiTestData.BookWithCategories.Title, BookYmiTestData.BookWithCategories.Authors!.Select(rs=>rs.Name.ToString()), BookYmiTestData.BookWithCategories.BookCategories!.Select(rs=>rs.Title.ToString()), new List<string>{ BookCondition.Good.ToString()}, 0, int.MaxValue}
        };
    [Theory]
    [MemberData(nameof(CanFindBookByTitleData))]
    public void CanFindBookByTitle(int expectedResultCount, string titleSearch, IEnumerable<string>? authorSearch, IEnumerable<string>? categorySearch, IEnumerable<string>? conditionSearch, int? paginationPage = 0, int? paginationTake = int.MaxValue)
    {
        // build the spec from theory data
        var findSpec = new BooksFindSpec(titleSearch, authorSearch, categorySearch, conditionSearch, paginationPage, paginationTake);

        // Get the test data
        var allBooks = BookYmiTestData.AllBooks;

        // When I evaluate the find by title spec
        _booksToTestWith = findSpec.Evaluate(allBooks).ToList();

        // Then the test book has the correct data
        _booksToTestWith.Should().NotBeNull();
        _booksToTestWith!.Count().Should().Be(expectedResultCount);
    }

    [Fact]
    public void CanCreateBookWithCopies()
    {
        // When I create a book with many copies
        ICreateABook(BookYmiTestData.BookManyCopies);

        // And test book has the correct book copies
        _bookToTestWith.BookCopies.Count().Should().Be(BookYmiTestData.BookManyCopies.BookCopies.Count());
    }

    [Fact]
    public void CanCreateBookWithCategories()
    {
        // When I set test data to a book with categories
        ICreateABook(BookYmiTestData.BookWithCategories);

        // Then book has the correct book categories
        _bookToTestWith.BookCategories.Count().Should().Be(BookYmiTestData.BookWithCategories.BookCategories.Count());
    }
}