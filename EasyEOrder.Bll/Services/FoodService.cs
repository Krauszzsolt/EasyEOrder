using EasyEOrder.Bll.DTOs;
using EasyEOrder.Bll.DTOs.Food;
using EasyEOrder.Bll.DTOs.Helper;
using EasyEOrder.Bll.DTOs.Wrapper;
using EasyEOrder.Bll.Interfaces;
using EasyEOrder.Dal.DBContext;
using EasyEOrder.Dal.Entities;
using EasyEOrder.Dal.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyEOrder.Bll.Services
{
    public class FoodService : IFoodService
    {

        private readonly EasyEOrderDbContext _context;

        public FoodService(EasyEOrderDbContext context)
        {
            _context = context;
        }

        public async Task<PageableList<FoodGroupByTypeDto>> GetFoodsGroupByType(FoodRequestQuery query)
        {
            var foodGroupByTypeDtoList = (await _context.Foods
                   .Include(x => x.FoodAllergens)
                   .Where(x => x.MenuId == query.MenuId) //new Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7")) // 
                   .ToListAsync())
                   .GroupBy(f => f.Category)
                   .Select(x => new FoodGroupByTypeDto()
                   {
                       Category = (int)x.Key,
                       Foods = x.Select(f => new FoodDto()
                       {
                           Id = f.Id,
                           Description = f.Description,
                           //FoodAllergens = f.FoodAllergens,
                           IsAvailable = f.IsAvailable,
                           Name = f.Name,
                           Price = f.Price,
                           Rating = f.Rating
                       }).ToList()
                   })
               .ToList();


            return new PageableList<FoodGroupByTypeDto>
            {
                Data = foodGroupByTypeDtoList,
                Count = foodGroupByTypeDtoList.Count(),
                Index = 0,
                PageSize = 10
            };
        }

        public async Task<FoodDetailsDto> GetFooDetails(Guid Id)
        {
            var entity = await _context.Foods
                .Include(x => x.FoodAllergens)
                .Include(x => x.Comments)
                .FirstOrDefaultAsync(x => x.Id == Id);

            if (entity == null)
            {
                throw new MyNotFoundException("Food not found!");
            }
            return new FoodDetailsDto()
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price,
                Category = (int)entity.Category,
                Rating = entity.Rating,
                Description = entity.Description,
                Comments = entity.Comments,
                //FoodAllergens = entity.FoodAllergens
            };
        }

        public async Task<List<FoodDto>> GetFoodListByIdList(List<Guid> Ids)
        {
            Dictionary<Guid, int> IdQuantityList = new Dictionary<Guid, int>();

            IdQuantityList = Ids.GroupBy(x => x)
              .Where(g => g.Count() >= 1)
              .ToDictionary(x => x.Key, y => y.Count());

            //var a = IdQuantityList.Get)(.Value

            return (await _context.Foods.AsNoTracking()
                .Where(dbFood => Ids
                    .Any(id => id == dbFood.Id))
                .ToListAsync())
                 .SelectMany(p => Enumerable.Range(0, IdQuantityList[p.Id])
                .Select(f => new FoodDto()
                {
                    Id = p.Id,
                    Description = p.Description,
                    //FoodAllergens = p.FoodAllergens,
                    //FoodCategories = (int)p.Category,
                    IsAvailable = p.IsAvailable,
                    Name = p.Name,
                    Price = p.Price,
                    Rating = p.Rating
                }))
                .ToList();
        }


        public async Task<List<FoodDto>> GetFoods()
        {
            return await _context.Foods
                .Select(x => new FoodDto()
                {
                    Id = x.Id,
                    Description = x.Description,
                    //FoodAllergens = x.FoodAllergens,
                    IsAvailable = x.IsAvailable,
                    Name = x.Name,
                    Price = x.Price,
                    Rating = x.Rating
                }).ToListAsync();
        }

        public async Task AddFood(FoodCreateDto foodCreateDto)
        {

            List<FoodAllergen> allergens = new List<FoodAllergen>();
            foodCreateDto.Allergens.ToList()
                .ForEach
                (x => allergens.Add(new FoodAllergen()
                {
                    Allergen = (Allergen)x,
                    //FoodId = foodCreateDto.Id
                }
                ));

            var entity = new Food()
            {

                Name = foodCreateDto.Name,
                MenuId = new Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7"),
                Description = foodCreateDto.Description,
                Category = (FoodCategories)foodCreateDto.Category,
                FoodAllergens = allergens,
                Price = foodCreateDto.Price,

            };

            if (foodCreateDto.Id != null)
            {
                entity.Id = foodCreateDto.Id;
            }
            //await _context.FoodAllergens.AddRangeAsync(allergens.ToArray());
            await _context.Foods.AddAsync(entity);
            _context.SaveChanges();
        }

        public async Task EditFood(FoodCreateDto foodCreateDto, Guid Id)
        {
            List<FoodAllergen> allergens = new List<FoodAllergen>();
            //if (foodCreateDto.FoodAllergens != null)
            //{
            //    foodCreateDto.FoodAllergens.ToList()
            //        .ForEach
            //        (x => allergens.Add(new FoodAllergen()
            //        {
            //            Allergen = x
            //        }
            //        ));
            //    await _context.FoodAllergens.AddRangeAsync(allergens.ToArray());
            //}


            var entity = new Food()
            {
                Id = Id,
                Name = foodCreateDto.Name,
                MenuId = new Guid("fe1ee058-9e79-4544-bf93-026f477fe844"),
                Description = foodCreateDto.Description,
                //Category = foodCreateDto.Category,
                FoodAllergens = allergens,
                Price = foodCreateDto.Price
            };

            _context.Foods.Update(entity);

            _context.SaveChanges();
        }

        public async Task<FoodCreateDto> GetFoodForEdit(Guid Id)
        {
            var entity = await _context.Foods
              .Include(x => x.FoodAllergens)
              .Include(x => x.Comments)
              .FirstOrDefaultAsync(x => x.Id == Id);


            var Allergens = entity.FoodAllergens.Select(x => x.Allergen).ToList();
            return new FoodCreateDto()
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price,
                //Category = entity.Category,
                Description = entity.Description,
                //FoodAllergens = Allergens
            };
        }

        public async Task DeleteFood(Guid Id)
        {
            var food = _context.Foods.Include(x => x.CartFoods).FirstOrDefault(x => x.Id == Id);
            if (food == null)
            {
                throw new MyNotFoundException("Food not found!");
            }
            else
            {
                _context.CartFoods.RemoveRange(food.CartFoods);
                _context.Foods.Remove(food);
                _context.SaveChanges();

            }

        }
    }
}
