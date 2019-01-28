using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShareRooms.WebUI.DAL;
using ShareRooms.WebUI.Models;
using System.Data.Entity;


namespace ShareRooms.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private ShareRoomsContext db = new ShareRoomsContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Country)
        {
            

            //var result = new ViewModelResult();
            //
            //result.Properties = db.Properties
            ////.Include(r =>db.Rooms)
            //.Join(db.Rooms, (p => p.RoomID),
            //(r => r.RoomID), ((p, r) => new { p.Streetaddress, p.State, p.Country, r.SizeinSqFt}))
            //.Where(x => x.p.Country.Contains(Country));
            //
            //
            ////  return View("SearchResult", result.Properties.ToList());
            //return View("SearchResult", result.Properties.ToList()); // test for github
        }
    }
}