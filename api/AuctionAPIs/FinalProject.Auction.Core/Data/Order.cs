using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FinalProject.Auction.Core.Data
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public float Total { get; set; }

        public DateTime? Date { get; set; }

        public float Profits { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual Useres users { get; set; }

        public ICollection<OrderProduct> orderProduct { get; set; }

    }
}
