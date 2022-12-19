using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FinalProject.Auction.Core.Data
{
    public class Bank
    {
        [Key]
        public int BankId { get; set; }

        public int? CardNumber { get; set; }

        public Double? Balance { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual Useres users { get; set; }
    }
}
