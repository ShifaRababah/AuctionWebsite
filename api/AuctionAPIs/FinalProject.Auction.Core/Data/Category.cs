using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FinalProject.Auction.Core.Data
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public ICollection<Category> category { get; set; }
    }
}
