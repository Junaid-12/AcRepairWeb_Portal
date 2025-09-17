using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcRepair.Models;

namespace AcRepair.Controllers
{
    public class AirCondustionerController : Controller
    {
        // GET: AirCondustioner
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserModel md)
        {
            AppllicationDbContext db = new AppllicationDbContext();
            db.UserAppoimentdata(md);
            return View();
        }
    
   
    }
}