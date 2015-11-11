using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DentalConsulting.Models;
using DentalConsultingData;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DentalConsulting.Controllers
	{  //[Authorize(Roles="administrator")]
	public class AdminPanelController : Controller
		{
		// GET: AdminPanel
		public ActionResult Index()
			{
			var roleManager = new RoleManager<Microsoft.AspNet.Identity.EntityFramework.IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
			return View(roleManager.Roles);
			}

		public ActionResult Insert()
		{
			return View();
		}

		[HttpPost,ActionName("Insert")]
		public ActionResult InsertRole()
		{
			return View("Index");
		}
		}
	}