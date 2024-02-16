using AutoMapper;
using ORJ.TaskToDo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORJ.TaskToDo.Application.UseCases.Users.CreateUser
{
    public sealed class CreateUserMapper : Profile
    {
        public CreateUserMapper()
        {
            CreateMap<CreateUserRequest, User>();
            CreateMap<User, CreateUserResponse>();
        }
    }
}
