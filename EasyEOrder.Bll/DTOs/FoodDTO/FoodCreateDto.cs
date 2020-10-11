
using EasyEOrder.Bll.DTOs.FoodDTO.Enums;
using System;

namespace EasyEOrder.Bll.DTOs
{
    public class FoodCreateDto : FoodDto
    {
        public FoodCategories Category { get; set; }

        public Guid RestaurantId { get; set; }
    }
}
