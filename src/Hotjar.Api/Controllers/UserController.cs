using Hotjar.Api.Controllers.Base;
using Hotjar.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Hotjar.Api.Controllers
{
    public class UserController : HotjarBaseController
    {
        private readonly IUserServices _userServices;

        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }
        /// <summary>
        /// Obtiene articulos por filtros
        /// </summary>
        /// <param name="registerData">Filters to apply</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Register(int registerData)
        {

            return Ok();
        }
        /// <summary>
        /// Obtiene articulos por filtros
        /// </summary>
        /// <param name="registerData">Filters to apply</param>
        /// <returns></returns>
        //[HttpPost]
        //[ProducesResponseType((int)HttpStatusCode.OK)]
        //[ProducesResponseType((int)HttpStatusCode.BadRequest)]
        //public async Task<IActionResult> Login(int registerData)
        //{

        //    return Ok();
        //}
        ///// <summary>
        ///// Obtiene articulos por filtros
        ///// </summary>
        ///// <param name="registerData">Filters to apply</param>
        ///// <returns></returns>
        //[HttpPost]
        //[ProducesResponseType((int)HttpStatusCode.OK)]
        //[ProducesResponseType((int)HttpStatusCode.BadRequest)]
        //public async Task<IActionResult> Refresh(int registerData)
        //{

        //    return Ok();
        //}
    }
}
