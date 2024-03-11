using Hotjar.Core.Entities;
using Hotjar.Core.Interfaces.Managers;
using Hotjar.Infrastructure.Dtos.Book;
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
        private readonly IBooksPerUsersManager _booksPerUsersManager;
        private readonly IBookManager _bookManager;
        public BookServices(IBookManager bookManager, IBooksPerUsersManager booksPerUsersManager) 
        {
            _bookManager = bookManager;
            _booksPerUsersManager = booksPerUsersManager;
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _bookManager.GetBooks();
        }
        public async Task BuyBook(BuyBookRequestDto buyBookRequestDto)
        {
            var resp = await _booksPerUsersManager.FindRelation(buyBookRequestDto.UserId, buyBookRequestDto.BookId);
            if (resp) throw new Exception();
                BooksPerUsers booksPerUsers = new()
                {
                    BookId = buyBookRequestDto.BookId,
                    UserId = buyBookRequestDto.UserId,

                };
                await _booksPerUsersManager.AddBookPerUser(booksPerUsers);

                return;
        }

        public async Task<IEnumerable<Book>> GetOwnBooks(int id)
        {
            try
            {
                var userBooksRelations = await _booksPerUsersManager.GetBooksPerUserByIdUser(id);
                var userBooks = userBooksRelations.Select(x => x.Book).ToList();
                return userBooks;
            } catch (Exception ex) { return null; }
        }
    }
}
