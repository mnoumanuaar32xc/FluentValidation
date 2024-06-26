using FluentValidation;
using FluentValidation.Validators;

namespace FluentValidationTestApp
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public Person(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }


    }

    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull().NotEmpty()
                .WithMessage("Name is required");

            RuleFor(x => x.Age)
                .NotNull().NotEmpty().InclusiveBetween(0, 100)
                .WithMessage("Age must be between 1 and 100");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Email address is required")
                      .EmailAddress().WithMessage("A valid email is required");
        }

    }
}
