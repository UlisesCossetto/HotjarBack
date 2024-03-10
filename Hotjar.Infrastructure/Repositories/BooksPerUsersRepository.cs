using Hotjar.Core.Entities;
using Hotjar.Core.Interfaces.Repositories;
using Hotjar.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotjar.Infrastructure.Repositories
{
    public class BooksPerUsersRepository : BaseRepository<BooksPerUsers>, IBooksPerUsersRepository
    {
        public BooksPerUsersRepository(HotjarDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<BooksPerUsers>> GetBooksPerUserByIdUser(int idUser)
        {
            return await _entities.Where(x => x.UserId == idUser).Include(x => x.Book).ToListAsync();
        }
    }
}
