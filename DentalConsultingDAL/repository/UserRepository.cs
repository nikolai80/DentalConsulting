using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DentalConsultingData;

namespace DentalConsultingDAL
	{

	public class UserRepository : IUser, IDisposable
		{
		private DentalConsultingContext context;
		public void Save()
			{
			throw new NotImplementedException();
			}

		public void DeleteUser(int userId)
			{
			throw new NotImplementedException();
			}

		public void EditUser(User user)
			{
			throw new NotImplementedException();
			}

		public void InsertUser(User user)
			{
			throw new NotImplementedException();
			}

		public User GetUserById(string userId)
			{
			throw new NotImplementedException();
			}

		public IEnumerable<User> GetUsers()
			{
			throw new NotImplementedException();
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
