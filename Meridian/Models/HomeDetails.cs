using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Meridian.Models
{
    public class HomeDetails
    {
        [Required]
        public int Id { get; set; }
        public string EnrollmentText { get; set; }
        public string EnrollementSubText { get; set; }
        public string PrimaryButtonText { get; set; }
        public string SecondaryButtonText { get; set; }
    }
}