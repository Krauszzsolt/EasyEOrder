using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Dal.Entities
{
    public class Menu : Base
    {
        public Guid Id { get; set; }

        public String Name { get; set; }

        public ICollection<Food> Foods { get; set; }

        public Restaurant Restaurant { get; set; }

        public Guid RestaurantId { get; set; }

    }
}
