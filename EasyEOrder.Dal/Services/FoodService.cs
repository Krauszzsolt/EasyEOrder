using EasyEOrder.Dal.DBContext;
using EasyEOrder.Dal.DTOs;
using EasyEOrder.Dal.Entities;
using EasyEOrder.Dal.Entities.Enums;
using EasyEOrder.Dal.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        }

        public async Task<FoodDetailsDto> GetFooDetails(Guid Id)
        {
            var entity = await _context.Foods
                .Include(x => x.FoodAllergens)
                .Include(x => x.Comments)
                .FirstAsync(x => x.Id == Id);

            return new FoodDetailsDto()
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price,
                Category = entity.Category,
                Rating = entity.Rating,
                BaseInfo = entity.BaseInfo,
                Comments = entity.Comments,
                FoodAllergens = entity.FoodAllergens
            };
        }
        public async Task<FoodCreateSelectItemsDto> GetFoodCreateSelectItems()
        {
            List<SelectListItem> MenuIds = await _context.Menus
                .Select(x =>
                new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.Name
                })
                .ToListAsync();

            List<SelectListItem> Categories = Enum.GetValues(typeof(FoodCategories)).Cast<FoodCategories>().Select(v => new SelectListItem
            {
                Text = v.ToString(),
                Value = ((int)v).ToString()
            }).ToList();

            return new FoodCreateSelectItemsDto { Menu = MenuIds, Category = Categories };


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
