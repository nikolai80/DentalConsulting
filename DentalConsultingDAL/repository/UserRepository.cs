using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using DentalConsultingData;

namespace DentalConsultingDAL
	{

	public class UserRepository : IUser, IDisposable
		{
		private DentalConsultingContext context;

		public UserRepository(DentalConsultingContext context)
		{
			this.context = context;
		}
		public void Save()
			{
			context.SaveChanges();
			}

		public void DeleteUser(int userId)
		{
			User user = context.Users.Find(userId);
			context.Users.Remove(user);
		}

		public void EditUser(User user)
			{
			context.Entry(user).State = EntityState.Modified;
			}

		public void InsertUser(User user)
			{
			context.Users.Add(user);
			}

		public User GetUserById(string userId)
			{
			return context.Users.Find(userId);
			}

		public IEnumerable<User> GetUsers()
			{
			return context.Users.ToList();
			}
		bool disposed = false;
		protected virtual void Dispose(bool disposing)
			{
			if(!this.disposed)
				{
				if(disposing)
					{
					context.Dispose();
					}
				}
			this.disposed = true;
			}
		public void Dispose()
		{
		Dispose(true);
		GC.SuppressFinalize(this);
		}
		}
}
