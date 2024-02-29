using Hotjar.Core.Interfaces.Managers;
using Hotjar.Core.Interfaces.Repositories;
using Hotjar.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotjar.Infrastructure.Services
{
    public class UserServices: IUserServices
    {
        private readonly IUserManager _userManager;

        public UserServices(IUserManager userManager)
        {
            _userManager = userManager;
        }
        public async Task Register()
        {

        }
        public async Task Login()
        {

        }
        public async Task Refresh()
        {

        }

        private async Task CreateToken()
        {

        }
    }
}
