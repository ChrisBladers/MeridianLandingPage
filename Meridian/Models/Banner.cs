using System.ComponentModel.DataAnnotations;

namespace Meridian.Models
{
    public class Banner
    {
        public int Id { get; set; }
        [Required]
        public string BannerImage { get; set; }
        public string BannerTitle { get; set; }
        public string BannerSubtitle { get; set; }
        public string BannerPrimaryButtonText { get; set; }
        public string BannerSecondaryButtonText { get; set; }
    }
}