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
using Meridian.Models;

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
            try {
                /*
            using (var ctx = new MeridianDBContext())
            {
                var stud = new HomeDetails() { EnrollementSubText = "Bill", EnrollmentText = "Tok", PrimaryButtonText = "T", SecondaryButtonText = "uopp" };
                    var test = new Banner()
                    {
                        BannerImage = "lady1.jpg",
                        BannerPrimaryButtonText = "Enroll Now",
                        BannerSecondaryButtonText = "Help Me Choose",
                        BannerSubtitle = "",
                        BannerTitle = "Annual Enrollment Period will begin on October 15th"
                    };
                    ctx.Banners.Add(test);
                    //ctx.UpdateGraph();
                ctx.HomeDetails.Add(stud);
                ctx.SaveChanges();
            }*/
                var banner = _homeRespository.GetBanner(1);
                return _homeHandler.MapToDTO(banner);
                //return _homeHandler.MapBannerToDTO();
        } catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }

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