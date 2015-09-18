using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DentalConsultingData
	{

	public class Advice
		{

		public int AdviceID
			{
			get;
			set;
			}

		public string AdviceText
			{
			get;
			set;
			}

		public virtual ICollection<User> Users { get; set; }
	}
}
