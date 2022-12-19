using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.Repository;
using FinalProject.Auction.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Infra.Service
{
   public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;

        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public bool CreateCart(Cart cart)
        {
            return _cartRepository.CreateCart(cart);
        }

        public bool DeleteCart(int id)
        {
            return _cartRepository.DeleteCart(id);
        }

        public Cart GetAllCart(int id)
        {
            return _cartRepository.GetAllCart(id);
        }


    }
}
