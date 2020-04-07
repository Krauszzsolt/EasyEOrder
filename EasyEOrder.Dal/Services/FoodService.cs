using EasyEOrder.Dal.DBContext;
using EasyEOrder.Dal.DTOs;
using EasyEOrder.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyEOrder.Dal.Services
{
    public class FoodService : IFoodService


    {

        private readonly EasyEOrderDbContext _context;
        public FoodService(EasyEOrderDbContext  context)
        {
            _context = context;
        }

        public FoodDto getFoodForTest(Guid Id)
        {
            return _context.Foods
                .Where(x => x.Id == Id)
                .Select(x =>  new FoodDto(){ 
                     Id = x.Id,              
                     BaseInfo  = x.BaseInfo,
                     Category = x.Category,
                     FoodAllergens = x.FoodAllergens,
                     IsAvailable = x.IsAvailable,
                     Name = x.Name,
                     Price = x.Price,
                     Rating = x.Rating
                }).First();
        }
    }
}
