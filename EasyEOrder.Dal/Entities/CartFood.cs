using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Dal.Entities
{
    public class CartFood
    {
        public Guid Id { get; set; }

        public Food Food { get; set; }

        public Guid FoodId { get; set; }

        public Cart Cart { get; set; }

        public Guid CartId { get; set; }

    }
}
