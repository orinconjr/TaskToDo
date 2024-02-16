using AutoMapper;
using ORJ.TaskToDo.Domain.Entities;

namespace ORJ.TaskToDo.Application.UseCases.Users.UpdateUser
{
    public sealed class UpdateUserMapper : Profile
    {
        public UpdateUserMapper()
        {
            CreateMap<UpdateUserRequest, User>();
            CreateMap<User, UpdateUserResponse>();
        }
    }
}
