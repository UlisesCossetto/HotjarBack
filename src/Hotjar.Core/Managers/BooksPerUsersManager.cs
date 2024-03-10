using Hotjar.Core.Entities;
using Hotjar.Core.Interfaces;
using Hotjar.Core.Interfaces.Managers;
using Hotjar.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotjar.Core.Managers
{
    public class BooksPerUsersManager : IBooksPerUsersManager
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBooksPerUsersRepository _booksPerUsersRepository;
        public BooksPerUsersManager(IUnitOfWork unitOfWork, IBooksPerUsersRepository booksPerUsersRepository)
        {
            _unitOfWork = unitOfWork;
            _booksPerUsersRepository = booksPerUsersRepository;
        }

        public async Task AddBookPerUser(BooksPerUsers booksPerUsers)
        {
            await _unitOfWork.BooksPerUsersRepository.Add(booksPerUsers);
            await _unitOfWork.SaveAsync();
        }
        public async Task<IEnumerable<BooksPerUsers>> GetBooksPerUserByIdUser(int idUser)
        {
            return await _unitOfWork.BooksPerUsersRepository.GetBooksPerUserByIdUser(idUser);
        }
    }
}
