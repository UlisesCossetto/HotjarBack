using Hotjar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotjar.Core.Interfaces.Repositories
{
    public interface IBooksPerUsersRepository : IRepository<BooksPerUsers>
    {
        public Task<IEnumerable<BooksPerUsers>> GetBooksPerUserByIdUser(int idUser);
    }
}
