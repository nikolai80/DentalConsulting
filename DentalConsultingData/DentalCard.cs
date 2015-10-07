using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalConsultingData
	{
	//Стоматологическая карта
	public class DentalCard
		{
		 [Key]
		public int DentalCardID
			{
			get;
			set;
			}

		public string DentalCardContent
			{
			get;
			set;
			}
		public int UserID { get; set; }
		[Required]
		public virtual User User { get; set; }
	}
	}
