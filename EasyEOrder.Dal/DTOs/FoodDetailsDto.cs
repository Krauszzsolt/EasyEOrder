using EasyEOrder.Dal.Entities;
using EasyEOrder.Dal.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Dal.DTOs
{
    public class FoodDetailsDto
    {

        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public FoodCategories Category { get; set; }

        public int Rating { get; set; }

        public string Description { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<FoodAllergen> FoodAllergens { get; set; }


    }
}
