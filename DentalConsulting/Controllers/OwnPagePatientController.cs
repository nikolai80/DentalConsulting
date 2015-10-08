using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DentalConsulting.Controllers
{
    public class OwnPagePatientController : Controller
    {
        // GET: OwnPagePatient
        public ActionResult Index()
        {
            return View();
        }
    }
}