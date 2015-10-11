using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DentalConsulting.Models;
using DentalConsultingDAL;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DentalConsulting
	{
	public class AcountInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
		{
		protected override void Seed(ApplicationDbContext context)
			{
			var userManager = new UserManager<ApplicationUser>(new

											UserStore<ApplicationUser>(context));

			var roleManager = new RoleManager<IdentityRole>(new
									  RoleStore<IdentityRole>(context));

			// создаем две роли
			var role1 = new IdentityRole { Name = "patient" };
			var role2 = new IdentityRole { Name = "doctor" };

			// добавляем роли в бд
			roleManager.Create(role1);
			roleManager.Create(role2);

			// создаем пользователей
			var patient = new ApplicationUser { Email = "post-gred@rambler.ru", UserName = "post-gred@rambler.ru" };
			string password = "123456";
			var result1 = userManager.Create(patient, password);
			var doctor = new ApplicationUser { Email = "homo-intellectus@tut.by", UserName = "homo-intellectus@tut.by" };
			var result2 = userManager.Create(doctor, password);

			// если создание пользователя прошло успешно
			if(result1.Succeeded)
				{
				// добавляем для пользователя роль
				userManager.AddToRole(patient.Id, role1.Name);
				}
			if(result2.Succeeded)
				{
				// добавляем для пользователя роль
				userManager.AddToRole(doctor.Id, role2.Name);
				}
			base.Seed(context);
			}
		}
	}