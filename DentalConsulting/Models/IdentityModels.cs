using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DentalConsulting.Models
{
    // Чтобы добавить данные профиля для пользователя, можно добавить дополнительные свойства в класс ApplicationUser. Дополнительные сведения см. по адресу: http://go.microsoft.com/fwlink/?LinkID=317594.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Обратите внимание, что authenticationType должен совпадать с типом, определенным в CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Здесь добавьте утверждения пользователя
            return userIdentity;
        }
		public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
	public class ApplicationRole : IdentityRole
		{
		public ApplicationRole() : base() { }

		public ApplicationRole(string name, string description)
			: base(name)
			{
			this.Description = description;
			}

		public virtual string Description { get; set; }
		}
	public class ApplicationUserRole : IdentityUserRole
		{
		public ApplicationUserRole()
			: base()
		{ }

		public ApplicationRole Role { get; set; }
		}
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
		public DbSet<ApplicationRole> Roles { get; set; }
        public ApplicationDbContext()
			: base("DentalConsulting", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

		public bool RoleExists(ApplicationRoleManager roleManager, string name)
			{
			return roleManager.RoleExists(name);
			}

		public bool CreateRole(ApplicationRoleManager _roleManager, string name, string description = "")
			{
			var idResult = _roleManager.Create<ApplicationRole, string>(new ApplicationRole(name, description));
			return idResult.Succeeded;
			}

		public bool AddUserToRole(ApplicationUserManager _userManager, string userId, string roleName)
			{
			var idResult = _userManager.AddToRole(userId, roleName);
			return idResult.Succeeded;
			}

		public void ClearUserRoles(ApplicationUserManager userManager, string userId)
			{
			var user = userManager.FindById(userId);
			var currentRoles = new List<IdentityUserRole>();

			currentRoles.AddRange(user.UserRoles);
			foreach(ApplicationUserRole role in currentRoles)
				{
				userManager.RemoveFromRole(userId, role.Role.Name);
				}
			}

		public void RemoveFromRole(ApplicationUserManager userManager, string userId, string roleName)
			{
			userManager.RemoveFromRole(userId, roleName);
			}

		public void DeleteRole(ApplicationDbContext context, ApplicationUserManager userManager, string roleId)
			{
			var roleUsers = context.Users.Where(u => u.UserRoles.Any(r => r.RoleId == roleId));
			var role = context.Roles.Find(roleId);

			foreach(var user in roleUsers)
				{
				this.RemoveFromRole(userManager, user.Id, role.Name);
				}
			context.Roles.Remove(role);
			context.SaveChanges();
			}
    }



}