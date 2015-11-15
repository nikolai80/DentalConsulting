using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DentalConsulting.Models;
using DentalConsultingData;
using DentalConsultingDAL;
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
			return View(roleToEdit);
			}

		[HttpPost]
		public async Task<ActionResult> Edit(IdentityRole role, FormCollection collection)
			{
			var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
			await roleManager.UpdateAsync(role);
			return RedirectToAction("Index");
			}

		public ActionResult UsersList()
		{
		var usersManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
			var users = usersManager.Users;
			DentalConsultingDAL.IUser userRepository =new UserRepository(new DentalConsultingContext());
			List<object> usersList = null;
			foreach (var user in users)
			{
				usersList.Add(new
				{
					UserName=userRepository.GetUsers().Select(u=>u.LoggedUserId==user.Id).FirstOrDefault(),
					UserEmail=user.Email
				});
			}
			ViewBag.UsersList = usersList;
			return View(users);
		}
		}
	}