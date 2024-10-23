using Budget_hotels_In_Delhi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Budget_hotels_In_Delhi.Controllers
{
    public class ContactUsController : Controller
    {
        // GET: ContactUs

        [HttpPost]
        public ActionResult AddContact(tbl_WebContactUs _cont)
        {

            return View();
        }
    }
}