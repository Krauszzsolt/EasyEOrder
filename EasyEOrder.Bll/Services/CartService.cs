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

        public async Task AddToCart(Guid foodId,string userId)
        {
            var food = await _context.Foods.FirstOrDefaultAsync(x => x.Id == foodId);
            if (food == null)
            {
                throw new MyNotFoundException("Food not found!");
            }

            var cart = await _context.Carts.FirstOrDefaultAsync(x => x.UserId == userId);
            if (cart == null)
            {
                cart = new Cart
                {
                    UserId = userId,
                    TotalPrice = food.Price,
                    OrderTime = new DateTime(),
                    Comment = "TEST",
                    ReservationId = new Guid("fe1ee058-9e79-4544-bf93-026f477fe849")
                };
                await _context.Carts.AddAsync(cart);
            }
            else
            {

                cart.TotalPrice += food.Price;
                _context.Carts.Update(cart);
            }

            var cartFood = new CartFood
            {
                Cart = cart,
                Food = food
            };

            await _context.CartFoods.AddAsync(cartFood);

           await _context.SaveChangesAsync();
        }

        public async Task<CartDto> GetCart(string userId)
        {         
            var cart = await _context.Carts.Include(x => x.CartFoods).ThenInclude(x => x.Food).FirstOrDefaultAsync(x => x.UserId == userId);
            if (cart == null)
            {
                throw new MyNotFoundException("There is no cart this user");
            }

            return new CartDto
            {
                Id = cart.Id,
                Foods = cart.CartFoods.Select(CartFoods =>  new FoodDto
                {
                    Id = CartFoods.Food.Id,
                    Description = CartFoods.Food.Description,
                    IsAvailable = CartFoods.Food.IsAvailable,
                    Name = CartFoods.Food.Name,
                    Price = CartFoods.Food.Price,
                    Rating = CartFoods.Food.Rating
                }).ToList(),
                UserId = userId,
                TotalPrice = cart.TotalPrice
            };
        }

        public async Task DeleteCart(string userId)
        {
            var cart = await _context.Carts.Include(x => x.CartFoods).FirstOrDefaultAsync(x => x.UserId == userId);
            if (cart == null)
            {
                throw new MyNotFoundException("There is no cart this user");
            }

            _context.CartFoods.RemoveRange(cart.CartFoods);
            _context.Carts.Remove(cart);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFromCart(Guid FoodId, string userId)
        {
            var cart = await _context.Carts.Include(x => x.CartFoods).ThenInclude(x => x.Food).FirstOrDefaultAsync(x => x.UserId == userId);
            if (cart == null)
            {
                throw new MyNotFoundException("There is no cart this user");
            }

            var cartFood = cart.CartFoods.FirstOrDefault(x => x.FoodId == FoodId);

            if (cartFood == null)
            {
                throw new MyNotFoundException("Food not found in cart!");
            }


            cart.TotalPrice -= cartFood.Food.Price;
            _context.Carts.Update(cart);
            _context.CartFoods.Remove(cartFood);

            await _context.SaveChangesAsync();
            
        }
    }
}
