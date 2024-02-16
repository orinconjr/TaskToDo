using Microsoft.EntityFrameworkCore;
using ORJ.TaskToDo.Domain.Entities;
using ORJ.TaskToDo.Domain.Interfaces;
using ORJ.TaskToDo.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORJ.TaskToDo.Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        { }

        public async Task<User> GetByEmail(string email, CancellationToken cancellationToken)
        {
            return await Context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
        }

        public async Task<User> GetById(Guid id, CancellationToken cancellationToken)
        {
            return await Context.Users.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }
    }
}
