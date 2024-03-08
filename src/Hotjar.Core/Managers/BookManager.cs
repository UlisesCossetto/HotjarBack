using Hotjar.Core.Entities;
using Hotjar.Core.Interfaces;
using Hotjar.Core.Interfaces.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotjar.Core.Managers
{
    public class BookManager: IBookManager
    {
        public readonly IUnitOfWork _unitOfWork;
        public BookManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _unitOfWork.BookRepository.GetBooks();
        }
    }
}
