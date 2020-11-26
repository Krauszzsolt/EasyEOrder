using EasyEOrder.Bll.DTOs;
using EasyEOrder.Bll.DTOs.Cart;
using EasyEOrder.Bll.DTOs.Helper;
using EasyEOrder.Bll.Interfaces;
using EasyEOrder.Dal.DBContext;
using EasyEOrder.Dal.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyEOrder.Bll.Services
{


    public class CartService : ICartService
    {
        private readonly EasyEOrderDbContext _context;

        public CartService(EasyEOrderDbContext context)
        {
            _context = context;
        }

        public async Task AddToCart(Guid foodId)
        {
            var food = await _context.Foods.FirstOrDefaultAsync(x => x.Id == foodId);
            var userId = "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db";
            var cart = await _context.Carts.FirstOrDefaultAsync(x => x.UserId == userId);
            if (cart == null)
            {
                cart = new Cart
                {
                    UserId = userId,
                    //FoodIds = new List<Guid>(),
                    TotalPrice = 0,
                    OrderTime = new DateTime(),
                };
            }

            //cart.FoodIds.Add(foodId);
            //    .Add(new Food
            //{
            //    Id = food.Id,
            //    Description = food.Description,
            //    IsAvailable = food.IsAvailable,
            //    Name = food.Name,
            //    Price = food.Price,
            //    Rating = food.Rating
            //});

            _context.Carts.Update(cart);

            _context.SaveChanges();
        }

        public async Task<CartDto> GetCart()
        {

            var userId = "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db";
            var cart = await _context.Carts.FirstOrDefaultAsync(x => x.UserId == userId);
            if (cart == null)
            {
                throw new MyNotFoundException("There is no cart this user");
            }

            return new CartDto
            {
                Id = cart.Id,
                //Foods = cart.Foods.Select(food => new FoodDto
                //{
                //    Id = food.Id,
                //    Description = food.Description,
                //    IsAvailable = food.IsAvailable,
                //    Name = food.Name,
                //    Price = food.Price,
                //    Rating = food.Rating
                //}).ToList(),
                //UserId = userId,
                //TotalPrice = cart.TotalPrice
            };
        }
    }
}
