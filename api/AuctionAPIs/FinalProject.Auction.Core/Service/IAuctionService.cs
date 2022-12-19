using FinalProject.Auction.Core.Data;
using FinalProject1.Auction1.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Core.Service
{
    public interface IAuctionService
    {
        bool UpdateAuctionPrice(Auctionn auction);
        List<AuctionnDTO> GetAllAuctionn();
    }
}
