using EasyEOrder.Bll.DTOs;
using EasyEOrder.Bll.DTOs.Cart;
using EasyEOrder.Bll.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EasyEOrder.Api.Controllers
{
    [Route("api/[controller]")]
    public class CartController : BaseController
    {

        private readonly ICartService _cartService;
        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        // GET: api/<controller>
        [HttpGet]
        public Task<CartDto> Get()
        {
            return _cartService.GetCart(CurrentUser.Id);
        }

        //// GET api/<controller>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";,
        //}

        // POST api/<controller>
        [HttpPost("AddToCart")]
        public Task AddToCart([FromBody]Guid FoodId)
        {
            //, [FromQuery] string UserId
            //Todo Add to list by Id

            return _cartService.AddToCart(FoodId, CurrentUser.Id);
        }

        // POST api/<controller>
        [HttpPost("Buy")]
        public async Task BuyCartContent()
        {
            // Is this post or get?
            //Todo Add to list by Id
            await _cartService.DeleteCart(CurrentUser.Id);
        }

        //// PUT api/<controller>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<controller>/5
        [HttpPost("RemoveFromCart")]
        public async Task RemoveFromCart([FromBody] Guid FoodId)
        {
            //Is this post or Delete?
            await _cartService.DeleteFromCart(FoodId ,CurrentUser.Id);
        }
    }
}
