using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyEOrder.Bll.DTOs;
using EasyEOrder.Bll.DTOs.Restaurant;
using EasyEOrder.Bll.DTOs.Wrapper;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EasyEOrder.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : BaseController
    {
        // GET: api/<RestaurantController>
        [HttpGet]
        public Task<PageableList<RestaruantDTO>> GetAllRestaurant()
        {
            return null;
        }

        // GET api/<RestaurantController>/5
        [HttpGet("{id}")]
        public Task<RestaruantDetailDto> GetRestaurant(Guid id)
        {
            return null;
        }

        // POST api/<RestaurantController>
        [HttpPost]
        public Task AddRestaurant([FromBody] RestaruantDTO restaurant)
        {
            return null;
        }

        // PUT api/<RestaurantController>/5
        [HttpPut("{id}")]
        public Task EditRestaurant(Guid id, [FromBody] RestaruantDTO restaurant)
        {
            return null;
        }

        // DELETE api/<RestaurantController>/5
        [HttpDelete("{id}")]
        public Task Delete(Guid id)
        {
            return null;
        }
    }
}
