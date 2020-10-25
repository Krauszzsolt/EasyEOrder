using EasyEOrder.Bll.DTOs;
using EasyEOrder.Bll.DTOs.Restaurant;
using EasyEOrder.Bll.DTOs.Wrapper;
using EasyEOrder.Bll.Interfaces;
using EasyEOrder.Dal.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyEOrder.Bll.Services
{
    public class RestaurantService : IRestaurantService
    {

        private readonly EasyEOrderDbContext _context;

        public RestaurantService(EasyEOrderDbContext context)
        {
            _context = context;
        }

        public async Task<PageableList<RestaruantDTO>> GetAllRestaurant(PageableRequestQuery requestQuery)
        {
            var restaurantList = (await _context.Restaurants.Select(r => new RestaruantDTO
            {
                Id = r.Id,
                Name = r.Name,
                Address = r.Address,
                Email = r.Email,
                MenuId = r.MenuId.GetValueOrDefault()
            }).ToListAsync());

            return new PageableList<RestaruantDTO>
            {
                Data = restaurantList,
                Count = 10,
                Index = 0,
                PageSize = 10
            };

        }

        public async Task<RestaruantDetailDto> GetRestaurant(Guid id)
        {
            var restaurant = await _context.Restaurants.Include(x => x.DayOfWeekOpenTimes).ThenInclude(x => x.OpenTimes).FirstOrDefaultAsync(x => x.Id == id);
            return new RestaruantDetailDto
            {
                Id = restaurant.Id,
                Name = restaurant.Name,
                Address = restaurant.Address,
                Email = restaurant.Email,
                MenuId = restaurant.MenuId.GetValueOrDefault(),
                DayOfWeekOpenTimes = restaurant.DayOfWeekOpenTimes.Select(x => new DayOfWeekOpenTimesDto
                {
                    DayOfWeek = x.DayOfWeek,
                    OpenTimes = new OpenTimeDTO
                    {
                        From = x.OpenTimes.From,
                        To = x.OpenTimes.To
                    }
                }).ToList()
            };
        }
    }
}
