using System;
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
		}
	}
