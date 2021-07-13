using System;
using System.Linq;
using Meridian.Repositories.Interfaces;
using Meridian.DTOs;
using Meridian.Models;
using Meridian.Services;   
namespace Meridian.Repositories
{
    public class HomeRepository : IHomeRepository
    {

        private readonly MeridianDBContext _dbContext;
        public HomeRepository(MeridianDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IQueryable<HangBannerDTO> GetHangBanners()
        {
            //return DataConnection.mcontext.HangBanners.OrderBy(x => x.HangBannerID);
            throw new NotImplementedException();
        }
        public Banner GetBanner(int Id)
        {
            return _dbContext.Banners.Where(i => i.Id == Id).FirstOrDefault();
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