using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using DentalConsultingData;

namespace DentalConsultingDAL
	{

	public class DentalCardRepository : IDentalCard, IDisposable
		{
		private DentalConsultingContext context;

		public DentalCardRepository(DentalConsultingContext context)
		{
			this.context = context;
		}
		public DentalCard GetDentalCardById(int dentalCardId)
		{
			DentalCard dentalCard = context.DentalCards.Find(dentalCardId);
			return dentalCard;
		}

		public void InsertDentalCard(DentalCard dentalCard)
			{
			context.DentalCards.Add(dentalCard);
			Save();
			}

		public void EditDentalCard(DentalCard dentalCard)
			{
			context.Entry(dentalCard).State=EntityState.Modified;
			Save();
			}

		public void DeleteDentalCard(int dentalCardId)
			{
			throw new NotImplementedException();
			}

		public void Save()
			{
			context.SaveChanges();
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
