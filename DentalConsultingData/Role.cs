using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalConsultingData
	{
	public class s
		{

		public int RoleID
			{
			get;
			set;
			}

		public string RoleTitle
			{
			get;
			set;
			}

		public virtual ICollection<User> Users { get; set; }
	}
	}
