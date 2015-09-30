using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DentalConsultingData;

namespace DentalConsultingDAL
	{

	public class HospitalChartRepository : IHospitalChart, IDisposable
		{
		private DentalConsultingContext context;
		public IEnumerable<HospitalChart> GetHospitalCharts()
			{
			throw new NotImplementedException();
			}

		public HospitalChart GetHospitalChartById(string hospitalChartId)
			{
			throw new NotImplementedException();
			}

		public void InsertHospitalChart(HospitalChart hospitalChart)
			{
			throw new NotImplementedException();
			}

		public void EditHospitalChart(HospitalChart hospitalChart)
			{
			throw new NotImplementedException();
			}

		public void DeleteHospitalChart(int hospitalChartId)
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
