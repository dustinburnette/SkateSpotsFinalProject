using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkateSpotsFinalProject.Models
{
    public class SkateSpot
    {
        public int SkateSpotID { get; set; }
        public string Description { get; set; }
        [Display (Name = "Title")]
        public string ShortDescription { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }

        public ApplicationUser User { get; set; }
        public string UserID { get; set; }

    }
}