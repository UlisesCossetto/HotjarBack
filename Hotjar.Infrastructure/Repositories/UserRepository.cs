using Hotjar.Core.Entidades;
using Hotjar.Core.Interfaces.Repositories;
using Hotjar.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotjar.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(HotjarDbContext context) : base(context)
        {
        }
    }
}
