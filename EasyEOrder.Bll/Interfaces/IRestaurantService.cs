using EasyEOrder.Bll.DTOs;
using EasyEOrder.Bll.DTOs.Restaurant;
using EasyEOrder.Bll.DTOs.RestaurantDTO;
using EasyEOrder.Bll.DTOs.Wrapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasyEOrder.Bll.Interfaces
{
    public interface IRestaurantService
    {
        public Task<PageableList<RestaruantDTO>> GetAllRestaurant(PageableRequestQuery requestQuery);

        public Task<RestaruantDetailDto> GetRestaurant(Guid id);

        public Task AddRestaurant(CreateRestaurantDto restaurant);
        public Task DeleteRestaurant(Guid id);


    }
}
