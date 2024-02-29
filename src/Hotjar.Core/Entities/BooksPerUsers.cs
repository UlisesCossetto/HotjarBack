using Hotjar.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotjar.Core.Entities
{
    public class BooksPerUsers
    {
        public int BookId { get; set; }
        public int UserId { get; set; }
        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}
