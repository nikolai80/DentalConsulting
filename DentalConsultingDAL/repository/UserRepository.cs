using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

		public void EditUser(DentalConsultingData.User user)
			{
			throw new NotImplementedException();
			}

		public void InsertUser(DentalConsultingData.User user)
			{
			throw new NotImplementedException();
			}

		public DentalConsultingData.User GetUserById(string userId)
			{
			throw new NotImplementedException();
			}

		public IEnumerable<DentalConsultingData.User> GetUsers()
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
