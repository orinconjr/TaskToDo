using MediatR;

namespace ORJ.TaskToDo.Application.UseCases.Users.GetAllUser
{
    public sealed record GetAllUserRequest : IRequest<List<GetAllUserResponse>>;
}
