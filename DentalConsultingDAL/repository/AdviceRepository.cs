using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DentalConsultingData;

namespace DentalConsultingDAL
	{

	public class AdviceRepository : IAdvice, IDisposable
		{
		private DentalConsultingContext context;
		public IEnumerable<Advice> GetAllAdvice()
			{
			throw new NotImplementedException();
			}

		public Advice GetAdviceById(string adviceId)
			{
			throw new NotImplementedException();
			}

		public void InsertAdvice(Advice advice)
			{
			throw new NotImplementedException();
			}

		public void EditAdvice(Advice advice)
			{
			throw new NotImplementedException();
			}

		public void DeleteAdvice(int adviceId)
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
