using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Core.DTO
{
    public class AddNewEmployeeDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public double Salary { get; set; }
        public string Position { get; set; }
        public string Password { get; set; }
   
        public int RoleId { get; set; }
    }
}