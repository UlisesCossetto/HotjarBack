using Hotjar.Core.Interfaces.Managers;
using Hotjar.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotjar.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        IBookRepository BookRepository { get; }
        IBooksPerUsersRepository BooksPerUsersRepository { get; }
        Task SaveAsync();
        void Save();
    }
}
