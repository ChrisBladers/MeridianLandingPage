using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Meridian.DTOs;
using Meridian.Services;
using Meridian.Services.Interfaces;
using Meridian.Handlers.Interfaces;
using Meridian.Repositories.Interfaces;
using Meridian.Handlers;

namespace Meridian.Services
{
    public class HomeService : IHomeService
    {
        private readonly IHomeHandler _homeHandler;
        private readonly IHomeRepository _homeRespository;

        public HomeService(IHomeHandler homeHandler, IHomeRepository homeRepository)
        {
            _homeHandler = homeHandler;
            _homeRespository = homeRepository;
        }
        public BannerDTO GetBanner()
        {
            return _homeHandler.MapBannerToDTO();
        }
        public IEnumerable<HangBannerDTO> GetHangBanners()
        {
            return _homeHandler.MapHangBannersToDTO();
        }
        public ContactDetailsDTO GetContactDetails()
        {
            return _homeHandler.MapContactDetailsToDTO();
        }

        public IEnumerable<ReasonDTO> GetReasons()
        {
            throw new NotImplementedException();
        }
        public ContactUsDTO GetContactUs()
        {
            throw new NotImplementedException();
        }

    }
}