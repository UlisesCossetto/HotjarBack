using Hotjar.Api.Controllers.Base;
using Hotjar.Core.Entities;
using Hotjar.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Hotjar.Api.Controllers
{
    public class BookController : HotjarBaseController
    {
        private readonly IBookServices _bookServices;
        public BookController(IBookServices bookServices) 
        {
            _bookServices = bookServices;
        }

        /// <summary>
        /// Obtiene todos los articulos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> BuyBook()
        {
            var resp = await _bookServices.GetBooks();
            return Ok(resp);
        }
    }
}
