using FluentValidation;

namespace ORJ.TaskToDo.Application.UseCases.Users.GetAllUser
{
    public class GetAllUserValidator : AbstractValidator<GetAllUserRequest>
    {
        public GetAllUserValidator()
        {
            //Sem validar
        }
    }
}
