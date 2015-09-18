using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DentalConsultingData;

namespace DentalConsultingDAL
	{

	public interface IHospitalChart
		{
		IEnumerable<HospitalChart> GetHospitalCharts();
		HospitalChart GetHospitalChartById(string hospitalChartId);
		void InsertHospitalChart(HospitalChart hospitalChart);
		void EditHospitalChart(HospitalChart hospitalChart);
		void DeleteHospitalChart(int hospitalChartId);
		void Save();
		}
}
