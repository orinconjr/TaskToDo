using MediatR;

namespace ORJ.TaskToDo.Application.UseCases.Users.UpdateUser
{
    public sealed record UpdateUserRequest(Guid Id,
                      string Email, string Name, string Password, bool Active)
                      : IRequest<UpdateUserResponse>;
}
