namespace YMI.YmiApplication.Shared.Validators;
public class ActorValidator : AbstractValidator<ActorViewModel>
{
    public ActorValidator()
    {
        RuleFor(x => x.Name.ToString())
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .NotNull()
            .Length(1, 40)
            ;
    }

    public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
    {
        var result = await ValidateAsync(ValidationContext<ActorViewModel>.CreateWithOptions((ActorViewModel)model, x => x.IncludeProperties(propertyName)));
        if (result.IsValid)
            return Array.Empty<string>();
        return result.Errors.Select(e => e.ErrorMessage);
    };
}
