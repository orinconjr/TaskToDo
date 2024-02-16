using MediatR;

namespace ORJ.TaskToDo.Application.UseCases.Users.CreateUser
{
    public sealed record CreateUserRequest(string Email, string Name, string Password, bool Active) : IRequest<CreateUserResponse>;

}
