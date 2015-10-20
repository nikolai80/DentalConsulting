﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalConsultingData
	{
	public class User
		{
		[Key]
		public int UserID { get; set; }

		public string LoggedUserId { get; set; }

		public string UserName { get; set; }

		public string UserSurname { get; set; }

		public DateTime UserDateOfBirth { get; set; }

		public virtual ICollection<Chat> Chats { get; set; }
		
		public virtual DentalCard DentalCard { get; set; }
		public virtual Role Role { get; set; }
		public virtual HospitalChart HospitalChart { get; set; }

		public virtual ICollection<Advice> Advices { get; set; }
		public virtual ICollection<TestResult> TestResults { get; set; }
		public virtual ICollection<Article> Articles { get; set; } 
		}
	}
