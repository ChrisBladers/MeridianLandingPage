using Meridian.DTOs;
using Meridian.Models;
using System.Collections.Generic;

namespace Meridian.Handlers.Interfaces
{
    public interface IHomeHandler
    {
        ContactDetailsDTO MapContactDetailsToDTO();
        BannerDTO MapBannerToDTO();

        BannerDTO MapToDTO(Banner banner);
        IEnumerable<HangBannerDTO> MapHangBannersToDTO();
        //IEnumerable<ReasonDetailsDTO> MapToDTO(ReasonDetails reasonDetails);
    }
}