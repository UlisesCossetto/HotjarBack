using Hotjar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotjar.Core.Entidades
{
    public class User : EntidadBase
    {
        public User()
        {
            Books = new HashSet<Book>();
        }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
