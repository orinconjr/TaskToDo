using MediatR;

namespace ORJ.TaskToDo.Application.UseCases.Users.DeleteUser
{
    public sealed record DeleteRequest(Guid Id)
                  : IRequest<DeleteUserResponse>;
}
