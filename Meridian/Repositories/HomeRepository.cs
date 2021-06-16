using System;
using System.Linq;
using Meridian.Repositories.Interfaces;
using Meridian.DTOs;

namespace Meridian.Repositories
{
    public class HomeRepository : IHomeRepository
    {
        public IQueryable<HangBannerDTO> GetHangBanners()
        {
            //return DataConnection.mcontext.HangBanners.OrderBy(x => x.HangBannerID);
            throw new NotImplementedException();
        }
        public BannerDTO GetBanner()
        {
            //return DataConnection.mcontext.Banner.FirstOrDefault();
            throw new NotImplementedException();
        }
        public IQueryable<ContactDetailsDTO> GetContactDetails()
        {
            //return DataConnection.mcontext.ContactDetails.FirstOrDefault();
            throw new NotImplementedException();
        }
        public IQueryable<ReasonDTO> GetReasons()
        {
            //return DataConnection.mcontext.Reasons.OrderBy(x => x.ReasonID);
            throw new NotImplementedException();
        }
        public IQueryable<ReasonDetailsDTO> GetReasonDetails(int reasonID)
        {
            //return DataConnection.mcontext.ReasonDetails.Where(x => x.ReasonID == reasonID);
            throw new NotImplementedException();
        }
    }
}