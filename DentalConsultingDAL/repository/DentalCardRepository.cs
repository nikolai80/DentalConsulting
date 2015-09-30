using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DentalConsultingData;

namespace DentalConsultingDAL
	{

	public class DentalCardRepository : IDentalCard, IDisposable
		{
		private DentalConsultingContext context;
		public DentalCard GetDentalCardById(string dentalCardId)
			{
			throw new NotImplementedException();
			}

		public void InsertDentalCard(DentalCard dentalCard)
			{
			throw new NotImplementedException();
			}

		public void EditDentalCard(DentalCard dentalCard)
			{
			throw new NotImplementedException();
			}

		public void DeleteDentalCard(int dentalCardId)
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
