using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DentalConsultingDAL
	{

	public class DentalCardRepository : IDentalCard, IDisposable
		{
		private DentalConsultingContext context;
		public DentalConsultingData.DentalCard GetDentalCardById(string dentalCardId)
			{
			throw new NotImplementedException();
			}

		public void InsertDentalCard(DentalConsultingData.DentalCard dentalCard)
			{
			throw new NotImplementedException();
			}

		public void EditDentalCard(DentalConsultingData.DentalCard dentalCard)
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
