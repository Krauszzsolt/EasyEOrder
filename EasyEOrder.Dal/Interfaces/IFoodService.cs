using EasyEOrder.Dal.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasyEOrder.Dal.Interfaces
{
    public interface IFoodService
    {
        public Task<List<FoodDto>> GetFoods();
        public Task<List<FoodGroupByTypeDto>> GetFoodsGroupByType();
        public Task<FoodDetailsDto> GetFooDetails(Guid Id);
        public Task AddFood(FoodCreateDto foodCreateDto);
        public Task<FoodCreateSelectItemsDto> GetFoodCreateSelectItems();
    }
}
