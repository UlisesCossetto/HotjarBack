using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotjar.Infrastructure.Interfaces
{
    public interface IUserServices
    {
        Task Register();
        Task Login();
        Task Refresh();
    }
}
