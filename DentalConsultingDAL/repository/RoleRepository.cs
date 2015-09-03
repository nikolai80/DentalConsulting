using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DentalConsultingDAL
	{

	public class RoleRepository : IRole, IDisposable
		{
		private DentalConsultingContext context;
		public IEnumerable<DentalConsultingData.Role> GetRoles()
			{
			throw new NotImplementedException();
			}

		public DentalConsultingData.Role GetRoleById(string roleId)
			{
			throw new NotImplementedException();
			}

		public void InsertRole(DentalConsultingData.Role role)
			{
			throw new NotImplementedException();
			}

		public void EditRole(DentalConsultingData.Role role)
			{
			throw new NotImplementedException();
			}

		public void DeleteRole(int roleId)
			{
			throw new NotImplementedException();
			}

		public void Save()
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
