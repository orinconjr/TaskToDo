using ORJ.TaskToDo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORJ.TaskToDo.Domain.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> GetById(Guid id, CancellationToken cancellationToken);
        Task<User> GetByEmail(string email, CancellationToken cancellationToken);
    }
}
