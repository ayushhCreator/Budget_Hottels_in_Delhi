using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Budget_hotels_In_Delhi.Models
{
    public class tbl_WebContactUs
    {
        [Required(ErrorMessage ="Enter Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Enter Email ID")]
        public string EmailID { get; set; }

        [Required(ErrorMessage = "Enter Phone Number")]
        public string PhoneNo { get; set; }
        public string QueryTopic { get; set; }
        public string Message { get; set; }
    }
}