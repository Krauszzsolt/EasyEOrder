using EasyEOrder.Bll.DTOs;
using EasyEOrder.Bll.DTOs.Food;
using EasyEOrder.Bll.DTOs.Wrapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyEOrder.Bll.Interfaces
{
    public interface IFoodService
    {
        public Task<List<FoodDto>> GetFoods();
        public Task<PageableList<FoodGroupByTypeDto>> GetFoodsGroupByType(FoodRequestQuery query);
        public Task<FoodDetailsDto> GetFooDetails(Guid Id);
        public Task AddFood(FoodCreateDto foodCreateDto);
        //public Task<FoodCreateSelectItemsDto> GetFoodCreateSelectItems();
        public Task<List<FoodDto>> GetFoodListByIdList(List<Guid> Ids);
        public Task<FoodCreateDto> GetFoodForEdit(Guid Id);
        public Task DeleteFood(Guid Id);
        public Task EditFood(FoodCreateDto foodCreateDto);
    }
}
