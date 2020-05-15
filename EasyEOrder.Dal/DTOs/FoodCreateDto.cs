using EasyEOrder.Dal.Entities;
using EasyEOrder.Dal.Entities.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Dal.DTOs
{
    public class FoodCreateDto
    {
        [HiddenInput]
        public Guid? Id { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }

        public FoodCategories Category { get; set; }

        public string Description { get; set; }

        public Guid MenuId { get; set; }

        public ICollection<Allergen> FoodAllergens { get; set; }

    }
}
