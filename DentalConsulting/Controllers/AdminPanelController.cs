using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
			var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
			return View(roleManager.Roles);
			}

		public ActionResult Insert()
		{
			return View();
		}

		[HttpPost]
		public async Task<ActionResult> Insert(IdentityRole role)
		{
		var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
			await roleManager.CreateAsync(role);
			return RedirectToAction("Index");
		}
		public async Task<ActionResult> Delete(string Id)
			{
			var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
			var roleToDelete = roleManager.FindById(Id);
			await roleManager.DeleteAsync(roleToDelete);
			return RedirectToAction("Index");
			}

		public ActionResult Edit(string id)
		{
		var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
		var roleToEdit = roleManager.FindById(id);
		return RedirectToAction("Index");
		}
		}
	}