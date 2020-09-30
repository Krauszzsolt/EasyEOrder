using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Bll.DTOs.Restaurant
{
    public class DayOfWeekOpenTimesDto
    {
        public DayOfWeek DayOfWeek { get; set; }

        public OpenTimeDTO OpenTimes { get; set; }
    }
}
