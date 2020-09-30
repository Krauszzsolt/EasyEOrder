using EasyEOrder.Bll.DTOs.Wrapper;
using System;

namespace EasyEOrder.Bll.DTOs.Food
{
    public class FoodRequestQuery : SearchableAndPageableRequestQuery
    {
        public Guid RestaruanId { get; set; }
    }
}
