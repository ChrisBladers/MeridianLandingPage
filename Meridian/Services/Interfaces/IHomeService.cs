using System;
using System.Collections.Generic;
using Meridian.DTOs;

namespace Meridian.Services.Interfaces
{
    public interface IHomeService
    {
        BannerDTO GetBanner();
        IEnumerable<HangBannerDTO> GetHangBanners();
        ContactDetailsDTO GetContactDetails();
        ContactUsDTO GetContactUs();
        IEnumerable<ReasonDTO> GetReasons();

    }
}
