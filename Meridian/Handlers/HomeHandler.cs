using System.Collections.Generic;
using System.Linq;
using Meridian.DTOs;
using System;
using Meridian.Handlers.Interfaces;

namespace Meridian.Handlers
{
    public class HomeHandler : IHomeHandler
    {
        /*public IEnumerable<ReasonDetailsDTO>MapToDTO(ReasonDetails reasonDetails)
        {
            return reasonDetails.Select(r => new ReasonDetailsDTO() 
            { 
                ReasonDetailsTitle = r.ReasonDetailsTitle, 
                ReasonDetailsHeader = r.ReasonDetailsHeader, 
                ReasonDetailsText = r.ReasonDetailsText,
                ReasonDetailsImage = r.ReasonDetailsImage
            });

        }*/
        public ContactDetailsDTO MapContactDetailsToDTO()
        {
            return new ContactDetailsDTO {
                PhoneNumber = "844-WHY-MCARE",
                AccessCode = "844-949-6227 (TTY:711)",
                ServiceHours = "Monday-Sunday, 8 a.m to 8 p.m."
            };
        }

        public IEnumerable<HangBannerDTO> MapHangBannersToDTO()
        {
            var hangBanners = new List<HangBannerDTO>()
            {
                new HangBannerDTO {
                    HangBannerButtonText = "LEARN MORE",
                    HangBannerIcon = "search",
                    HangBannerTitle = "Help Me Choose My Plan",
                    HangBannerText = "Take a look at our plans and choose the one that best fits your needs."
                },
                new HangBannerDTO {
                    HangBannerButtonText = "LEARN MORE",
                    HangBannerIcon = "article",
                    HangBannerTitle = "Enroll Now",
                    HangBannerText = "Fill out an enrollment form and become a part of our family today."
                },
                new HangBannerDTO {
                    HangBannerButtonText = "LEARN MORE",
                    HangBannerIcon = "person",
                    HangBannerTitle = "Provider Search",
                    HangBannerText = "MeridianCare has a large network of providers in your area. Click to see our network!"
                },
            };

            return hangBanners;
        }

        public BannerDTO MapBannerToDTO()
        {
            var banners = new BannerDTO
            {
                BannerImage = "lady1.jpg",
                BannerPrimaryButtonText = "Enroll Now",
                BannerSecondaryButtonText = "Help Me Choose",
                BannerSubtitle = "",
                BannerTitle = "Annual Enrollment Period will begin on October 15th"
            };

            return banners;
        }

    }
}