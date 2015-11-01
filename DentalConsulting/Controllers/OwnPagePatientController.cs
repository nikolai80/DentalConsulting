using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DentalConsultingData;
using DentalConsultingDAL;

namespace DentalConsulting.Controllers
{
	[Authorize(Roles = "patient")]
    public class OwnPagePatientController : Controller
    {
		private DentalConsultingDAL.IUser userRepository;

		public OwnPagePatientController()
	    {
		    this.userRepository = new UserRepository(new DentalConsultingContext());
	    }

		public OwnPagePatientController(DentalConsultingDAL.IUser userRepository)
	    {
		    this.userRepository = userRepository;
	    }
        // GET: OwnPagePatient
        public ActionResult Index(string userId)
        {
		if(!String.IsNullOrEmpty(userId))
			{
			User user = userRepository.GetUsers().First(u => u.LoggedUserId == userId);
			return View(user);
			}
		else
			{
			return Redirect("/Home/Index");
			}
        }

		//GET:OwnPagePatient/EditUser
		public ActionResult EditUser(int id)
		{
			var user = userRepository.GetUserById(id);
			return View(user);
		}

		[HttpPost]
		public ActionResult EditUser(int id, FormCollection formCollection)
		{
		var user = userRepository.GetUserById(id);
			userRepository.EditUser(user);
			return RedirectToAction("Index");
		}
    }
}