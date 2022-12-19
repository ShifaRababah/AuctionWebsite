using FinalProject.Auction.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Core.Service
{
   public interface IJWTService
    {
        string Auth(Login login);
    }
}
