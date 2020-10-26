using EasyEOrder.Bll.DTOs.Restaurant;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Bll.DTOs.RestaurantDTO
{
    public class CreateRestaurantDto : RestaruantDTO
    {
        public List<DayOfWeekOpenTimesDto> DayOfWeekOpenTimes { get; set; }

    }
}
