using FluentValidation;


namespace Application.Features.Brands.Commands.Create;

public class CreateBrandCommandValidator:AbstractValidator<CreateBrandCommand>
{
    //kurallar
    public CreateBrandCommandValidator()
    {
        RuleFor(c => c.Name).NotEmpty().MinimumLength(2);
    }
}