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
using Microsoft.AspNet.Identity.Owin;
using IUser = Microsoft.AspNet.Identity.IUser;

namespace DentalConsulting.Controllers
	{  //[Authorize(Roles="administrator")]
	public class AdminPanelController : Controller
		{
		ApplicationDbContext context = new ApplicationDbContext();
		RoleManager<IdentityRole> roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));

		UserManager<ApplicationUser> userManager =
			System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
		// GET: AdminPanel
		public ActionResult Index()
			{
			return View(roleManager.Roles);
			}

		public ActionResult Insert()
			{
			return View();
			}

		[HttpPost]
		public async Task<ActionResult> Insert(IdentityRole role)
			{
			await roleManager.CreateAsync(role);
			return RedirectToAction("Index");
			}
		public async Task<ActionResult> Delete(string Id)
			{
			var roleToDelete = roleManager.FindById(Id);
			await roleManager.DeleteAsync(roleToDelete);
			return RedirectToAction("Index");
			}

		public ActionResult Edit(string id)
			{
			var roleToEdit = roleManager.FindById(id);
			return View(roleToEdit);
			}

		[HttpPost]
		public async Task<ActionResult> Edit(IdentityRole role, FormCollection collection)
			{
			await roleManager.UpdateAsync(role);
			return RedirectToAction("Index");
			}

		public ActionResult UsersList()
			{
			AppUsers model = new AppUsers();
			return View(model);
			}
		//GET:AdminPanel/EditUserRole
		public ActionResult EditUserRole(string userId, string roleId)
			{
			// prepopulat roles for the view dropdown
			var list = context.Roles.OrderBy(r => r.Name).ToList().Select(rr => new SelectListItem { Value = rr.Name.ToString(), Text = rr.Name }).ToList();
			ViewBag.Roles = list;
			var appUser = userManager.FindById(userId);
			if(!String.IsNullOrEmpty(roleId))
				{
				var roleName = roleManager.FindById(roleId).Name;
				if(userManager.IsInRole(userId, roleName))
					{
					userManager.RemoveFromRole(userId, roleName);
					ViewBag.ResultMessage = "Role removed from this user successfully !";
					}
				else
					{
					ViewBag.ResultMessage = "This user doesn't belong to selected role.";
					} 
				} 
			return View(appUser);
			}

		//POST:AdminPanel/EditUserRole
		[HttpPost]
		[ActionName("EditUserRole")]
		public ActionResult AddUserToRole(string UserName, string RoleName)
		{
		ApplicationUser user = context.Users.Where(u => u.UserName.Equals(UserName, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
		userManager.AddToRole(user.Id, RoleName);
		ViewBag.ResultMessage = "Role created successfully !";
			return RedirectToAction("UsersList");
		}


		private void AddRoleToUser(string UserName, string RoleName)
			{
			ApplicationUser user = context.Users.Where(u => u.UserName.Equals(UserName, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
			userManager.AddToRole(user.Id, RoleName);
			ViewBag.ResultMessage = "Role created successfully !";


			}

		}
	}