﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalConsultingData
	{
	public class User
		{

		public int UserID { get; set; }

		public string UserName { get; set; }

		public string UserSurname { get; set; }

		public DateTime UserDateOfBirth { get; set; }

		public virtual ICollection<Chat> Chats { get; set; }
		public virtual DentalCard DentalCard { get; set; }
		public virtual ICollection<s> Roles { get; set; }
		public virtual HospitalChart HospitalChart { get; set; }

		public virtual ICollection<Advice> Advices { get; set; }
		public virtual ICollection<TestResult> TestResults { get; set; }
		public virtual ICollection<Reminder> Reminders { get; set; }
		}
	}
