using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FinalProject.Auction.Core.Data
{
    public class OrderProduct
    {
        [Key]
        public int OrderProductId { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product product { get; set; }

        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order order { get; set; }
    }
}
