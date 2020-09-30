using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Bll.DTOs.Restaurant
{
    public class RestaruantDetailDto : RestaruantDTO
    {
        public List<DayOfWeekOpenTimesDto> DayOfWeekOpenTimes { get; set; }

    }
}
