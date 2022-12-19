using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.Repository;
using FinalProject.Auction.Core.Service;
using FinalProject1.Auction1.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Infra.Service
{
   public class AuctionService: IAuctionService
    {

        private readonly IAuctionRepository auctionRepository;
        public AuctionService(IAuctionRepository _auctionRepository)
        {
            auctionRepository = _auctionRepository;
        }
        public bool UpdateAuctionPrice(Auctionn auction)
        {

            return auctionRepository.UpdateAuctionPrice(auction);
        }

        public List<AuctionnDTO> GetAllAuctionn()
        {

            return auctionRepository.GetAllAuctionn();
        }

    }
}
