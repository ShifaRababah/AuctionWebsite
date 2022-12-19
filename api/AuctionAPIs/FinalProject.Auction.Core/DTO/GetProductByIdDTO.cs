using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Core.DTO
{
    public class GetProductByIdDTO
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public float ? PriceProduct { get; set; }
        public DateTime ? StartDate { get; set; }
        public DateTime ? EndDate { get; set; }

        public string ? Image { get; set; }
        public string Description { get; set; }
        public float ? Price { get; set; }
        public int UserId { get; set; }

    }
}
