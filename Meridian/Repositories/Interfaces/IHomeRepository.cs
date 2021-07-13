using System;
using System.Collections.Generic;
using System.Linq;
using Meridian.DTOs;
using Meridian.Models;

namespace Meridian.Repositories.Interfaces
{
    public interface IHomeRepository
    {
        IQueryable<HangBannerDTO> GetHangBanners();
        Banner GetBanner(int Id);
        IQueryable<ContactDetailsDTO> GetContactDetails();
        IQueryable<ReasonDTO> GetReasons();
        IQueryable<ReasonDetailsDTO> GetReasonDetails(int reasonID);
    }
}
