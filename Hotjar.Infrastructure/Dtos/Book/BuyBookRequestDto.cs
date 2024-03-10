using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotjar.Infrastructure.Dtos.Book
{
    public class BuyBookRequestDto
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
    }
}
