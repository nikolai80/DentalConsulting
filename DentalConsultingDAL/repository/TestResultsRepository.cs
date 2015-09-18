using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DentalConsultingDAL
	{

	public class TestResultRepository : ITestResult, IDisposable
		{
		private DentalConsultingContext context;
		public void Save()
			{
			throw new NotImplementedException();
			}

		public void DeleteTestResult(int userId)
			{
			throw new NotImplementedException();
			}

		public void EditTestResult(DentalConsultingData.TestResult user)
			{
			throw new NotImplementedException();
			}

		public void InsertTestResult(DentalConsultingData.TestResult user)
			{
			throw new NotImplementedException();
			}

		public DentalConsultingData.TestResult GetTestResultById(string userId)
			{
			throw new NotImplementedException();
			}

		public IEnumerable<DentalConsultingData.TestResult> GetTestResult()
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
