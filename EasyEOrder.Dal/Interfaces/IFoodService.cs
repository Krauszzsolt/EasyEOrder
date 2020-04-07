﻿using EasyEOrder.Dal.DTOs;
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
    }
}
