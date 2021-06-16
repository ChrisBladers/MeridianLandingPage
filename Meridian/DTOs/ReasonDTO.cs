using System.Collections.Generic;

namespace Meridian.DTOs
{
    public class ReasonDTO
    {
        public int ReasonID { get; set; }
        public string ReasonTitle { get; set; }
        public IEnumerable<ReasonDetailsDTO> ReasonDetails { get; set; }
    }
}