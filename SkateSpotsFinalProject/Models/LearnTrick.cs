using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkateSpotsFinalProject.Models
{
    public class LearnTrick
    {
        public int LearnTrickID { get; set; }
        [Display(Name = "Tricks To Learn")]
        public string TrickName { get; set; }

    }
}