using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Budget_hotels_In_Delhi.Models
{
    public class tbl_TourPackage
    {
        public int Id { get; set; }
        public string PackName { get; set; }
        public string PackPrice { get; set; }
        public string PackImage { get; set; }
        public string PackDetails { get; set; }


        public string TourHeading { get; set; }
        public string TourImages { get; set; } 
       public string TourDuration { get; set; }
        public string TourOverview { get; set; }
        public string TourHighlights { get; set; }
        public string TourItinerary1  { get; set; }
        public string TourItinerary2 { get; set; }
        public string TourItinerary3 { get; set; }
        public string TourItinerary4{ get; set; }
       


    }
}