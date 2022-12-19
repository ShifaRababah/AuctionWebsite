using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FinalProject.Auction.Core.Data
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }

        public DateTime? Date { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual Useres users { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product product { get; set; }
    }
}
