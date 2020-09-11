using EasyEOrder.Bll.DTOs;
using EasyEOrder.Bll.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EasyEOrder.Api.Controllers
{
    [Route("api/[controller]")]
    public class FoodController : BaseController
    {
        private readonly IFoodService _foodService;
        public FoodController(IFoodService foodService)
        {
            _foodService = foodService;
        }


        // GET: api/<controller>
        [HttpGet]
        public async Task<List<FoodGroupByTypeDto>> GetAll()
        {
            return await _foodService.GetFoodsGroupByType();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<FoodDetailsDto> Get(Guid id)
        {
            return await _foodService.GetFooDetails(id);
        }

        // POST api/<controller>
        [HttpPost]
        public async void Post([FromBody]FoodCreateDto newFood)
        {
            await _foodService.AddFood(newFood);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async void Put(Guid id, [FromBody]FoodCreateDto newFood)
        {
            await _foodService.EditFood(newFood);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async void Delete(Guid id)
        {
            await _foodService.DeleteFood(id);
        }
    }
}
