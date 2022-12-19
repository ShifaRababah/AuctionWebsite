using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject1.Auction1.Core.DTO
{
  public  class CustomerDTO
    {

        public int UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public float? Salary { get; set; }

        public string Position { get; set; }
    }
}
