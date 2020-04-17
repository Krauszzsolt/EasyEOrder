using EasyEOrder.Dal.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Dal.Entities
{
    public class FoodAllergen : Base
    {
        public Guid Id { get; set; }

        public Food Food { get; set; }

        public Guid FoodId { get; set; }

        public Allergen Allergen { get; set; }

    }
}
