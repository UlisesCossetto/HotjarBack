using Hotjar.Core.Entities;
using Hotjar.Core.Interfaces.Managers;
using Hotjar.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotjar.Infrastructure.Services
{
    public class BookServices : IBookServices
    {
        private readonly IBookManager _bookManager;
        public BookServices(IBookManager bookManager) 
        {
            _bookManager = bookManager;
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _bookManager.GetBooks();

        }
    }
}
