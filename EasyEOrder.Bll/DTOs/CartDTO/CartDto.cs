using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Bll.DTOs.Cart
{
    public class CartDto
    {
        public Guid Id { get; set; }

        public List<FoodDto> Foods { get; set; }

        public int TotalPrice { get; set; }

        public string Comment { get; set; }

        public DateTime OrderTime { get; set; }

        public string UserId { get; set; }

    }
}
