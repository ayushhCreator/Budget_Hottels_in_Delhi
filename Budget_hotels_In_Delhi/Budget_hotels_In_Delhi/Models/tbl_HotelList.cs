using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Budget_hotels_In_Delhi.Models
{
    public class tbl_HotelList
    {
        public int Id { get; set; } 
        public string HotelName { get; set; } 
        public string HotelPrice { get; set; } 
        public string HotelImage{ get; set; }


        //HotelDetailsPage

        public string htl_Heading { get; set; }
     
        public string htl_Duration { get; set; }
        public string htl_image { get; set; }
        public string htl_Overview { get; set; }
        public string htl_Galance { get; set; }
        public string htl_Amenities { get; set; }
        public string htl_room_Amenities { get; set; }
        public string htl_feepolicies { get; set; }
        

    }
}