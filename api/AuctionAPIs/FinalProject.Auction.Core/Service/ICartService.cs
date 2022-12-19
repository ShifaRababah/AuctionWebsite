using FinalProject.Auction.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Core.Service
{
   public interface ICartService
    {
        bool CreateCart(Cart cart);
        Cart GetAllCart(int id);
        bool DeleteCart(int id);
    }
}
