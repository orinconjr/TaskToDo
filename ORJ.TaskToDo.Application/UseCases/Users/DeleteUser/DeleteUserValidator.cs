using FluentValidation;

namespace ORJ.TaskToDo.Application.UseCases.Users.DeleteUser
{
    public class DeleteValidator :
    AbstractValidator<DeleteRequest>
    {
        public DeleteValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
