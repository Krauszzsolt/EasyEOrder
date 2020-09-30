using EasyEOrder.Bll.DTOs;
using EasyEOrder.Bll.DTOs.Cart;
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
        // GET: api/<controller>
        [HttpGet]
        public Task<CartDto> Get()
        {
            //[FromQuery]String userId
            return null;
        }

        //// GET api/<controller>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";,
        //}

        // POST api/<controller>
        [HttpPost("AddToCart")]
        public Task AddToCart([FromBody] Guid FoodId)
        {
            //, [FromQuery] string UserId
            //Todo Add to list by Id
            return null;
        }

        // POST api/<controller>
        [HttpPost("Buy")]
        public Task BuyCartContent()
        {
            // Is this post or get?
            //Todo Add to list by Id
            return null;
        }

        //// PUT api/<controller>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<controller>/5
        [HttpPost("RemoveFromCart")]
        public Task RemoveFromCart([FromBody] Guid Id)
        {
            //Is this post or Delete?
            return null;
        }
    }
}
