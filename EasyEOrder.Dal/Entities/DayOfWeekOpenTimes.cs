using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Dal.Entities
{
    public class DayOfWeekOpenTimes : Base
    {
        public Guid Id{ get; set; }

        public Guid RestaurantId { get; set; }
        
        public DayOfWeek DayOfWeek { get; set; }

        public OpenTime OpenTimes { get; set; }
    }
}
