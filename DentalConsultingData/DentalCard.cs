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
		[ForeignKey("User")]
		public int UserID
			{
			get;
			set;
			}

		public string Reason
			{
			get;
			set;
			}

		public string GeneralStateOfHealth { get; set; }
		/// <summary>
		///Конфигурация лица
		/// </summary>
		public string ConfigurationFace { get; set; }
		/// <summary>
		///Состояние кожных покровов, красной каймы
		/// </summary>
		public string SkinCovering { get; set; }
		/// <summary>
		///Состояние регионаргых лимфатических узлов
		/// </summary>
		public string LymphNodes { get; set; }
		/// <summary>
		///Состояние височно-нижнечелюстного состава
		/// </summary>
		public string TemporalJoint { get; set; }
		/// <summary>
		/// Прикус
		/// </summary>
		public string Bite { get; set; }
		public virtual User User { get; set; }
		}
	}
