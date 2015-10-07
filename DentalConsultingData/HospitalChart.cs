using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalConsultingData
	{
	// История болезни
	public class HospitalChart
		{
		 [Key]
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
		 [Required]
		public virtual User User { get; set; }
	}
	}
