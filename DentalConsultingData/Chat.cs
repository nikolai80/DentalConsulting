using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalConsultingData
	{
	/*Класс для чата между доктором и пользователем*/
	public class Chat
		{

		public int ChatID { get; set; }

		public virtual ICollection<User> Doctor
			{
			get;set;
			}

	}
	}
