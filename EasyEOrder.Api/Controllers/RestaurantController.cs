using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyEOrder.Bll.DTOs;
using EasyEOrder.Bll.DTOs.Restaurant;
using EasyEOrder.Bll.DTOs.RestaurantDTO;
using EasyEOrder.Bll.DTOs.Wrapper;
using EasyEOrder.Bll.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EasyEOrder.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : BaseController
    {

        private readonly IRestaurantService _restaurantService;
        public RestaurantController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }
        // GET: api/<RestaurantController>
        [HttpGet]
        public Task<PageableList<RestaruantDTO>> GetAllRestaurant([FromQuery]PageableRequestQuery? requestQuery)
        {
            return _restaurantService.GetAllRestaurant(requestQuery);
        }

        // GET api/<RestaurantController>/5
        [HttpGet("{id}")]
        public Task<RestaruantDetailDto> GetRestaurant(Guid id)
        {
            return _restaurantService.GetRestaurant(id);
        }

        // POST api/<RestaurantController>
        [HttpPost]
        public Task AddRestaurant([FromBody] CreateRestaurantDto restaurant)
        {
            return _restaurantService.AddRestaurant(restaurant);
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
            return _restaurantService.DeleteRestaurant(id);
        }
    }
}
