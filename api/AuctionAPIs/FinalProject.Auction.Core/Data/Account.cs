using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FinalProject.Auction.Core.Data
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        public float Value { get; set; }

        public string Description { get;set; }

        public DateTime? Date { get; set; }


        //[ForeignKey("UserId")]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual Useres users { get; set; }

        
    }
}
