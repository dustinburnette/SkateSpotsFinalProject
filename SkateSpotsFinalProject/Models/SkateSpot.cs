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
        public int Lat { get; set; }
        public int Long { get; set; }

    }
}