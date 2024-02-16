using AutoMapper;
using ORJ.TaskToDo.Domain.Entities;

namespace ORJ.TaskToDo.Application.UseCases.Users.GetAllUser
{
    public sealed class GetAllUserMapper : Profile
    {
        public GetAllUserMapper()
        {
            CreateMap<User, GetAllUserResponse>();
        }
    }
}
