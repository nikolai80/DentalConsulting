using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DentalConsulting.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DentalConsulting
	{
	public class AcountInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
	{
		 protected override void Seed(ApplicationDbContext context)
            {
                var UserManager = new UserManager<ApplicationUser>(new 

                                                UserStore<ApplicationUser>(context)); 

                var RoleManager = new RoleManager<IdentityRole>(new 
                                          RoleStore<IdentityRole>(context));
     
                 string name = "User";
                 string password = "123456";
			     string role = "patient";


				 //Create Role patient if it does not exist
                if (!RoleManager.RoleExists(name))
                {
                    var roleresult = RoleManager.Create(new IdentityRole(role));
                }
     
                //Create User=Admin with password=123456
				var user = new ApplicationUser();
                user.UserName = name;
                var patientresult = UserManager.Create(user, password);
     
                //Add User Admin to Role Admin
                if (patientresult.Succeeded)
                {
                    var result = UserManager.AddToRole(user.Id, role);
                }
                base.Seed(context);
            }
		}
	}