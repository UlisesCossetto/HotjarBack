using Hotjar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotjar.Core.Interfaces.Managers
{
    public interface IBooksPerUsersManager
    {
        public Task AddBookPerUser(BooksPerUsers booksPerUsers);
        public Task<IEnumerable<BooksPerUsers>> GetBooksPerUserByIdUser(int idUser);
    }
}
