using FinalProject.Auction.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Core.Repository
{
   public interface ICartRepository
    {
        bool CreateCart(Cart cart);
        Cart GetAllCart(int id);
        bool DeleteCart(int id);
    }
}
