﻿using EasyEOrder.Dal.Entities;
using EasyEOrder.Dal.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Dal.DTOs
{
    public class FoodDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public int Rating { get; set; }

        public bool IsAvailable { get; set; }

        public string BaseInfo { get; set; }

        public ICollection<FoodAllergen> FoodAllergens { get; set; }

    }
}