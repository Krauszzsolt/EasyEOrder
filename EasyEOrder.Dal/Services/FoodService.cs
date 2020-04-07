using EasyEOrder.Dal.DBContext;
using EasyEOrder.Dal.DTOs;
using EasyEOrder.Dal.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyEOrder.Dal.Services
{
    public class FoodService : IFoodService


    {

        private readonly EasyEOrderDbContext _context;
        public FoodService(EasyEOrderDbContext context)
        {
            _context = context;
        }
        public async Task<List<FoodGroupByTypeDto>> GetFoodsGroupByType()
        {
            var result = new List<FoodGroupByTypeDto>();
            var foodgroups = (await _context.Foods.ToListAsync()).GroupBy(f => f.Category);
            result = foodgroups.Select(x => new FoodGroupByTypeDto()
            {
                Category = x.Key,
                Foods = x.Select(f => new FoodDto()
                {
                    Id = f.Id,
                    BaseInfo = f.BaseInfo,
                    FoodAllergens = f.FoodAllergens,
                    IsAvailable = f.IsAvailable,
                    Name = f.Name,
                    Price = f.Price,
                    Rating = f.Rating
                }).ToList()
            })
            .ToList();
            return result;
            //  return (await _context.Foods.ToListAsync()).GroupBy(
            //   f => f.Category,
            //   f => new FoodDto()
            //   {
            //       Id = f.Id,
            //       BaseInfo = f.BaseInfo,
            //       FoodAllergens = f.FoodAllergens,
            //       IsAvailable = f.IsAvailable,
            //       Name = f.Name,
            //       Price = f.Price,
            //       Rating = f.Rating
            //   },
            //    (Key, g) => new FoodGroupByTypeDto() { Category = Key, Foods = g.ToList()}
            //  ).ToList();
         }

            public async Task<List<FoodDto>> GetFoods()
        {
            return await _context.Foods
                .Select(x => new FoodDto()
                {
                    Id = x.Id,
                    BaseInfo = x.BaseInfo,
                    FoodAllergens = x.FoodAllergens,
                    IsAvailable = x.IsAvailable,
                    Name = x.Name,
                    Price = x.Price,
                    Rating = x.Rating
                }).ToListAsync();
        }
    }
}
