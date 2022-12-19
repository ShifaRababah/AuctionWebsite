using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.Repository;
using FinalProject.Auction.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Infra.Service
{
    public class HomePageService: IHomePageService
    {
        private readonly IHomePageRepository homePageRepository;

        public HomePageService(IHomePageRepository _homePageRepository)
        {

            homePageRepository = _homePageRepository;


        }


        public bool UpdateHomePage(HomePage homePage) 
        { return homePageRepository.UpdateHomePage(homePage); }
    }
}
