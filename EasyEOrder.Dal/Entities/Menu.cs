using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Dal.Entities
{
    public class Menu
    {
        public Guid Id { get; set; }

        public ICollection<Food> Foods { get; set; }

        public Guid RestaurantId { get; set; }

    }
}
