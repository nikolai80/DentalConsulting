using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DentalConsultingData
	{

	public class ChatMessage
		{

		[Key]
		public int ChatMessageID { get; set; }
		public string MessageText
			{
			get;
			set;
			}
		public DateTime MessageDate { get; set; }
		public int ChatID { get; set; }
		public virtual Chat Chat { get; set; }
		}
	}
