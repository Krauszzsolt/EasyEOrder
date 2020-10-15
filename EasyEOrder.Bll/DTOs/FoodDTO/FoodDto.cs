using EasyEOrder.Bll.DTOs.FoodDTO.Enums;
using System;
using System.Collections.Generic;

namespace EasyEOrder.Bll.DTOs
{
    public class FoodDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public int Rating { get; set; }

        public bool IsAvailable { get; set; }

        public string Description { get; set; }

        public List<Allergen> Allergens { get; set; }

        //public int? FoodCategories { get; set; }

    }
}
