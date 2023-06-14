namespace TPL.Application.Validators;
public class BookInCategoryValidator : AbstractValidator<BookInCategoryViewModel>
{
    public BookInCategoryValidator()
    {
        
    }

    public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
    {
        var result = await ValidateAsync(ValidationContext<BookInCategoryViewModel>.CreateWithOptions((BookInCategoryViewModel)model, x => x.IncludeProperties(propertyName)));
        if (result.IsValid)
            return Array.Empty<string>();
        return result.Errors.Select(e => e.ErrorMessage);
    };
}
