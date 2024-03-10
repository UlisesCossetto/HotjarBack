using Hotjar.Api.Controllers.Base;
using Hotjar.Core.Entities;
using Hotjar.Infrastructure.Dtos.Book;
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
        /// Obtiene todos los Libros
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetBooks()
        {
            var resp = await _bookServices.GetBooks();
            return Ok(resp);
        }        
        
        /// <summary>
        /// Realizar la compra del libro
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> BuyBook(BuyBookRequestDto buyBookRequestDto)
        {
            await _bookServices.BuyBook(buyBookRequestDto);
            return Ok();
        }       
        
        /// <summary>
        /// Realizar la compra del libro
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        [AllowAnonymous]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetOwnBooks(int id)
        {
            var resp = await _bookServices.GetOwnBooks(id);
            return Ok(resp);
        }
    }
}
