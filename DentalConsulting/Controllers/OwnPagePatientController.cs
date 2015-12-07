using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DentalConsulting.Models;
using DentalConsultingData;
using DentalConsultingDAL;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

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
			ApplicationUser userIdentity = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
			if(userIdentity != null)
				{
				User user = userRepository.GetUsers().First(u => u.LoggedUserId == userIdentity.Id);
				return View(user);
				}
			else
				{
				return RedirectToAction("Index", "Home");
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
			var userToUpdate = userRepository.GetUserById(id);
			if(TryUpdateModel(userToUpdate))
				{
				userRepository.EditUser(userToUpdate);
				}
			return RedirectToAction("Index","OwnPagePatient");
			}
		}
	}