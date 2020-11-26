using EasyEOrder.Bll.DTOs.Cart;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasyEOrder.Bll.Interfaces
{
    public interface ICartService
    {
        public Task<CartDto> GetCart();
        public Task AddToCart(Guid foodId);

    }
}
