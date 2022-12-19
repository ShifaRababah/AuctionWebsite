using FinalProject.Auction.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Core.Service
{
   public interface IAttendService
    {
        public bool CreateAttend(Attend attend);
    }
}
