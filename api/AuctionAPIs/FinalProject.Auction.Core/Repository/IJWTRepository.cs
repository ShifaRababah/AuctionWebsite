using FinalProject.Auction.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Core.Repository
{
   public interface IJWTRepository
    {
        Login Authentication(Login login);
    }
}
