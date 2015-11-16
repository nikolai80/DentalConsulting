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
		public IEnumerable<ApplicationUser> IdentityAppUser { get; set; }
		public IEnumerable<User> AppUser { get; set; }
		public IEnumerable<IdentityRole> AppRoles { get; set; }

		


		public AppUsers()
		{
		var usersManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
		var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
		DentalConsultingDAL.IUser userRepository = new UserRepository(new DentalConsultingContext());
		var appUsers = userRepository.GetUsers();//получили всех пользователей	
		}
		}
	}