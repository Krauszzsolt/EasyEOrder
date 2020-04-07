using EasyEOrder.Dal.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Dal.DTOs
{
    public class FoodGroupByTypeDto
    {
        public FoodCategories Category { get; set; }

        public List<FoodDto> Foods { get; set; }
    }
}
