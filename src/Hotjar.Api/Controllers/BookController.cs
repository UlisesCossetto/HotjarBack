using Hotjar.Api.Controllers.Base;
using Hotjar.Infrastructure.Interfaces;
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
        /// Obtiene articulos por filtros
        /// </summary>
        /// <param name="registerData">Filters to apply</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> BuyBook(int registerData)
        {

            return Ok();
        }
    }
}
