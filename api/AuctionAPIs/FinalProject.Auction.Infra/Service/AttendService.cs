using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.Repository;
using FinalProject.Auction.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Infra.Service
{
   public class AttendService: IAttendService
    {
        private readonly IAttendRepository attendRepository;

        public AttendService(IAttendRepository _attendRepository)
        {

            attendRepository = _attendRepository;



        }
        public bool CreateAttend(Attend attend) 
        { return attendRepository.CreateAttend(attend); }


    }
}
