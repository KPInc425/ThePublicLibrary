﻿namespace TPL.Application.Validators;
public class MemberValidator : AbstractValidator<MemberViewModel>
{
    public MemberValidator()
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
        var result = await ValidateAsync(ValidationContext<MemberViewModel>.CreateWithOptions((MemberViewModel)model, x => x.IncludeProperties(propertyName)));
        if (result.IsValid)
            return Array.Empty<string>();
        return result.Errors.Select(e => e.ErrorMessage);
    };
}
