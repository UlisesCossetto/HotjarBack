using Hotjar.Core.Entities;
using Hotjar.Infrastructure.Dtos.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotjar.Infrastructure.Interfaces
{
    public interface IBookServices
    {
        public Task<IEnumerable<Book>> GetBooks();
        public Task BuyBook(BuyBookRequestDto buyBookRequestDto);
        public Task<IEnumerable<Book>> GetOwnBooks(int id);
    }
}
