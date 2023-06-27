namespace YMI.YmiApplication.Shared.Validators;
public class DigitalAddyVOValidator : AbstractValidator<DigitalAddyVOViewModel>
{
    public DigitalAddyVOValidator()
    {
        RuleFor(x => x.Value)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .NotNull()
            .Length(1, 40)
            ;
    }

    public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
    {
        var result = await ValidateAsync(ValidationContext<DigitalAddyVOViewModel>.CreateWithOptions((DigitalAddyVOViewModel)model, x => x.IncludeProperties(propertyName)));
        if (result.IsValid)
            return Array.Empty<string>();
        return result.Errors.Select(e => e.ErrorMessage);
    };
}
