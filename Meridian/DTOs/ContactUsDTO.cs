using System.Collections.Generic;

namespace Meridian.DTOs
{
    public class ContactUsDTO
    {
        public string ContactHeader { get; set; }
        public string ContactText { get; set; }
        public string ReasonText { get; set; }
        public string ContactButtonText { get; set; }
        public string ContactButtonColor { get; set; }
        public string ContactImage { get; set; }

        public IEnumerable<InputDTO> ContactInput { get; set; }
    }
}