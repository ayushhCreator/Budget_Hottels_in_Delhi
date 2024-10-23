
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;

using System.Data;
using Dotplus.Database.StoreProcedure;
using Budget_hotels_In_Delhi.Models;
using System.Web.UI.HtmlControls;

namespace Budget_hotels_In_Delhi.Controllers
{
    public class HomeController : Controller
    {


        private Database db;
        public HomeController()
        {
            db = Database.GetInstance("DBCS");
        }



        public ActionResult Index()
        {

            return View();
        }


        [Route("About")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application page.";

            return View();
        }


        [Route("AboutDelhi")]
        public ActionResult AboutDelhi()
        {

            return View();
        }


        [Route("HotelList")]
        public ActionResult HotelList()
        {

            //try
            //{

            //    var result = db.fn_DataTable("SpHotelListTable1").AsEnumerable().Select(s => new tbl_HotelList
            //    {
            //        Id = s.Field<int>("Id"),
            //        HotelName = s.Field<string>("HotelName"),
            //        HotelPrice = s.Field<string>("HotelPrice"),
            //        HotelImage = s.Field<string>("HotelImage"),
            //    }).ToList();
            //    ViewBag.MyList = result;
            //}

            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}

            //return View();

            try
            {
                DataSet DS = db.Dp_DataSet("SpHotelListTable1");
                var budget = DS.Tables[0];
                var deluxe = DS.Tables[1];
                var heritage = DS.Tables[2];

                var Res1 = budget.AsEnumerable().Select(s => new tbl_HotelList
                {
                    Id = s.Field<int>("Id"),
                    HotelName = s.Field<string>("HotelName"),
                    HotelPrice = s.Field<string>("HotelPrice"),
                    HotelImage = s.Field<string>("HotelImage")
                }).ToList();

                var Res2 = deluxe.AsEnumerable().Select(s => new tbl_HotelList
                {
                    Id = s.Field<int>("Id"),
                    HotelName = s.Field<string>("HotelName"),
                    HotelPrice = s.Field<string>("HotelPrice"),
                    HotelImage = s.Field<string>("HotelImage")
                }).ToList();

                var Res3 = heritage.AsEnumerable().Select(s => new tbl_HotelList
                {
                    Id = s.Field<int>("Id"),
                    HotelName = s.Field<string>("HotelName"),
                    HotelPrice = s.Field<string>("HotelPrice"),
                    HotelImage = s.Field<string>("HotelImage")
                }).ToList();

                ViewBag.BudHotel = Res1;
                ViewBag.DeluxeHotel = Res2;
                ViewBag.HeritagHotel = Res3;
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message);
            }
            return View();

        }

        [Route("Details/{id}")]
        public ActionResult Details(int id)
        {
            try
            {
                List<tbl_HotelList> Res = new List<tbl_HotelList>();
                SqlParameter[] param = new SqlParameter[]
                {
                new SqlParameter("@htl_id",id)
                };
                var DB_Result = db.fn_DataTable("Web_spHotelDetails", param).AsEnumerable().Select(s => new tbl_HotelList
                {
                    htl_Heading = s.Field<string>("htl_Heading"),
                    htl_image = s.Field<string>("htl_image"),
                    htl_Duration = s.Field<string>("htl_Duration"),
                    htl_Overview = s.Field<string>("htl_Overview"),
                    htl_Galance = s.Field<string>("htl_Galance"),
                    htl_Amenities = s.Field<string>("htl_Amenities"),
                    htl_room_Amenities = s.Field<string>("htl_room_Amenities"),
                    htl_feepolicies = s.Field<string>("htl_feepolicies"),
                    
                }).ToList();

                ViewBag.PackageMasterDetails = DB_Result;
            }
  
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return View();

        }



        [Route("TourPackages")]
        public ActionResult TourPackages()
        {

            try
            {

                var result = db.fn_DataTable("SpTourPackageTable").AsEnumerable().Select(s => new tbl_TourPackage
                {
                    Id = s.Field<int>("Id"),
                    PackName = s.Field<string>("PackName"),
                    PackPrice = s.Field<string>("PackPrice"),
                    PackImage = s.Field<string>("PackImage"),
                    PackDetails = s.Field<string>("PackDetails"),
                }).ToList();
                ViewBag.MyList = result;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return View();
        }





        [Route("TourPackageDetails/{id}")]
        public ActionResult TourPackageDetails(int id)
        {

            try
            {
                List<tbl_TourPackage> Res = new List<tbl_TourPackage>();
                SqlParameter[] param = new SqlParameter[]
                {
                new SqlParameter("@Packid",id)
                };
                var DB_Result = db.fn_DataTable("Web_spTourPackageDetails", param).AsEnumerable().Select(s => new tbl_TourPackage
                {
                    TourHeading = s.Field<string>("TourHeading"),
                    TourImages = s.Field<string>("TourImages"),
                    TourDuration = s.Field<string>("TourDuration"),
                    TourOverview = s.Field<string>("TourOverview"),
                    TourHighlights = s.Field<string>("TourHighlights"),
                    TourItinerary1 = s.Field<string>("TourItinerary1"),
                    TourItinerary2 = s.Field<string>("TourItinerary2"),
                    TourItinerary3 = s.Field<string>("TourItinerary3"),
                    TourItinerary4 = s.Field<string>("TourItinerary4"),
                }).ToList();

                ViewBag.PackageMasterDetails = DB_Result;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return View();


        }






        [Route("Service")]
        public ActionResult Service()
        {
            ViewBag.Message = "Service";

            return View();
        }

       

        [Route("TopDestination")]
        public ActionResult TopDestination()
        {

            return View();
        }

        [Route("Gallery")]
        public ActionResult Gallery()
        {
            return View();
        }

        [Route("Contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact";
            return View();
        }

        //[HttpPost]
        //[Route("Contact")]
        //public ActionResult Contact(tbl_WebContactUs _cont)
        //{
            
        //    return View();
        //}

    }
}