using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DentalConsulting.Controllers
{
    public class OwnDoctorPageController : Controller
    {
        // GET: OwnDoctorPage
        public ActionResult Index()
        {
            return View();
        }

		//GET: DoctorArticles
	    public ActionResult GetArticles()
	    {
		    return View();
	    }
    }
}