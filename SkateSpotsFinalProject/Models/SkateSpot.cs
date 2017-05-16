using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkateSpotsFinalProject.Models
{
    public class SkateSpot
    {
        public int SkateSpotID { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }

    }
}