using AutoMapper;
using ORJ.TaskToDo.Domain.Entities;

namespace ORJ.TaskToDo.Application.UseCases.Users.DeleteUser
{
    public sealed class DeleteMapper : Profile
    {
        public DeleteMapper()
        {
            CreateMap<DeleteRequest, User>();
            CreateMap<User, DeleteUserResponse>();
        }
    }
}
