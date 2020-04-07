using EasyEOrder.Dal.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Dal.Interfaces
{
    public interface IFoodService
    {

        public FoodDto getFoodForTest(Guid Id);
    }
}
