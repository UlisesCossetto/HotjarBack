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
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(HotjarDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _entities.ToListAsync();
        }
    }
}
