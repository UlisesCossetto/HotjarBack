using Hotjar.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotjar.Core.Entities
{
    public class Book : EntidadBase
    {
        public Book()
        {
            Users = new HashSet<User>();
        }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public virtual ICollection<User> Users { get; set;}
    }
}
