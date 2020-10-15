using EasyEOrder.Bll.DTOs;
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

    }
}
