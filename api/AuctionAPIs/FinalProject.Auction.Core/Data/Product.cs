using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FinalProject.Auction.Core.Data
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string Title { get; set; }

        public float PriceProduct { get; set; }

        public DateTime ?StartDate { get; set; }

        public DateTime ?EndDate { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category category { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual Useres users { get; set; }

        public int Status { get; set; }

        public ICollection<Auctionn> auction { get; set; }

        public ICollection<Cart> cart { get; set; }

        public ICollection<OrderProduct> orderProduct { get; set; }
    }
}
