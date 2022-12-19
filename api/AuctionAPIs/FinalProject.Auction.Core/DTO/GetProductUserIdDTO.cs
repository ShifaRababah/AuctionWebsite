using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Core.DTO
{
   public class GetProductUserIdDTO
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }

        public int ? CategoryId { get; set; }

        public int ? Status { get; set; }
      
        public float ? Price { get; set; }

    }
}
