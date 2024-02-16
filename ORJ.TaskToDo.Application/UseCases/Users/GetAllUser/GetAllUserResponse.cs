using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORJ.TaskToDo.Application.UseCases.Users.GetAllUser
{
    public sealed record GetAllUserResponse
    {
        public Guid Id { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
        public bool Active { get; set; }
    }
}
