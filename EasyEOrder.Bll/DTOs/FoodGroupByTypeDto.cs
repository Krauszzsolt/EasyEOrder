using EasyEOrder.Dal.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Bll.DTOs
{
    public class FoodGroupByTypeDto
    {
        public int Category { get; set; }

        public List<FoodDto> Foods { get; set; }
    }
}
