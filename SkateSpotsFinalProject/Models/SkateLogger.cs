using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkateSpotsFinalProject.Models
{
    public class SkateLogger
    {
        public int SkateLoggerID { get; set; }
        [Display(Name = "Trick Name")]
        public string TrickName { get; set; }
        [Display(Name = "Number of Attempts")]
        public int Attempts { get; set; }
        [Display(Name = "Successfully Landed?")]
        public bool Landed { get; set; }
        [Display(Name = "How Long Practiced in Minutes")]
        public TimeSpan HowLongMinutes { get; set; }

    }
}