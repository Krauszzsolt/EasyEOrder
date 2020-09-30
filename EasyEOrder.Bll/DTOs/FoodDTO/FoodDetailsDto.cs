using EasyEOrder.Dal.Entities;
using EasyEOrder.Dal.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Bll.DTOs
{
    public class FoodDetailsDto : FoodDto
    {

        public ICollection<Comment> Comments { get; set; }

        public int Category { get; set; }

    }
}
