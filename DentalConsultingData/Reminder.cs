using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DentalConsultingData
	{

	public class Reminder
		{

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
