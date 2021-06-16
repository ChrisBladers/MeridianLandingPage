using System;
using System.Collections.Generic;
using System.Linq;
using Meridian.DTOs;

namespace Meridian.Repositories.Interfaces
{
    public interface IHomeRepository
    {
        IQueryable<HangBannerDTO> GetHangBanners();
        BannerDTO GetBanner();
        IQueryable<ContactDetailsDTO> GetContactDetails();
        IQueryable<ReasonDTO> GetReasons();
        IQueryable<ReasonDetailsDTO> GetReasonDetails(int reasonID);
    }
}
