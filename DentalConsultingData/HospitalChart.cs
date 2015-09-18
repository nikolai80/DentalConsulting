using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalConsultingData
	{
	// История болезни
	public class HospitalChart
		{

		public int HospitalChartID
			{
			get;
			set;
			}

		public string HospitalChartContent
			{
			get;
			set;
			}

		public virtual User User { get; set; }
	}
	}
