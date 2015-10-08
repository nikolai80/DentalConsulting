using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalConsultingData
	{
	public class Role
		{
		 [Key, ForeignKey("User")]
		public int UserID
			{
			get;
			set;
			}

		public string RoleTitle
			{
			get;
			set;
			}

		public virtual User User { get; set; }
	}
	}
