using EasyEOrder.Dal.Entities;
using EasyEOrder.Dal.Entities.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Bll.DTOs
{
    public class FoodCreateDto : FoodDto
    {
        public FoodCategories Category { get; set; }

        public Guid RestaurantId { get; set; }
    }
}
