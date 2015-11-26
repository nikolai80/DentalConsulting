using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DentalConsultingData;
using DentalConsultingDAL;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DentalConsulting.Models
	{
	public class AppUsers
		{
		public List<ApplicationUser> IdentityAppUser { get; set; }
		public List<User> AppUser { get; set; }
		public List<IdentityRole> AppRoles { get; set; }




		public AppUsers()
			{
			var usersManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
			var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
			DentalConsultingDAL.IUser userRepository = new UserRepository(new DentalConsultingContext());
			this.AppUser = userRepository.GetUsers().ToList();//получили всех пользователей
			this.IdentityAppUser = usersManager.Users.ToList();
			this.AppRoles = UsersRoles(this.IdentityAppUser);
			
			}

		public List<IdentityRole> UsersRoles(List<ApplicationUser> identityUsers)
			{
			var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
			List<IdentityRole> usersRoles = new List<IdentityRole>();
			foreach(var identityUser in identityUsers)
				{
				var userRole = identityUser.Roles.Single();
				if(userRole != null)
					{
					var role = roleManager.FindById(userRole.RoleId);
					usersRoles.Add(role);
					}

				}
			return usersRoles;
			}
		}
	}