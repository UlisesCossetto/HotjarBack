using Hotjar.Core.Entities;
using Hotjar.Core.Interfaces;
using Hotjar.Core.Interfaces.Managers;
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
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly HotjarDbContext _context;
        private readonly IUserRepository _userRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IBooksPerUsersRepository _booksPerUsersRepository;
        public UnitOfWork(HotjarDbContext context)
        {
            _context = context;
        }
        public IBookRepository BookRepository => _bookRepository ?? new BookRepository(_context);
        public IBooksPerUsersRepository BooksPerUsersRepository => _booksPerUsersRepository ?? new BooksPerUsersRepository(_context);
        public IUserRepository UserRepository => _userRepository ?? new UserRepository(_context);
        public void Dispose()
        {
            _context?.Dispose();
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
