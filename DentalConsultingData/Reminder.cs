using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DentalConsultingData
	{

	public class Reminder
		{
		 [Key]
		public int ReminderID
			{
			get;
			set;
			}

		public string ReminderText
			{
			get;
			set;
			}

		public virtual User User { get; set; }
	}
}
