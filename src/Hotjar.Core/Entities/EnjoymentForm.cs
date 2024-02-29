using Hotjar.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotjar.Core.Entities
{
    public class EnjoymentForm : EntidadBase
    {
        public int SatisfactionLevel { get; set; }
        public string Observations { get; set; }
        public bool MoreRelated { get; set; }
        public bool ReadTheSameAuthor { get; set; }
    }
}
