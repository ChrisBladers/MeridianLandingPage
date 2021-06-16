﻿using Meridian.DTOs;
using System.Collections.Generic;

namespace Meridian.Handlers.Interfaces
{
    public interface IHomeHandler
    {
        ContactDetailsDTO MapContactDetailsToDTO();
        BannerDTO MapBannerToDTO();
        IEnumerable<HangBannerDTO> MapHangBannersToDTO();
        //IEnumerable<ReasonDetailsDTO> MapToDTO(ReasonDetails reasonDetails);
    }
}