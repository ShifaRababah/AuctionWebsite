using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Core.DTO
{
    public class PurchasesInfoDTO
    {

      
        public float total { get; set; }
        public DateTime? date { get; set; }
        public int status { get; set; }
        public float profits { get; set; }
        public int userid { get; set; }
        public string Title { get; set; }
        public string image { get; set; }
    }
}
