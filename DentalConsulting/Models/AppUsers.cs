using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DentalConsultingData;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DentalConsulting.Models
	{
	public class AppUsers
		{
		public IEnumerable<ApplicationUser> IdentityAppUser { get; set; }
		public IEnumerable<User> AppUser { get; set; }
		public IEnumerable<IdentityRole> AppRoles { get; set; }
		}
	}