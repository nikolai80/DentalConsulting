using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalConsultingData
	{
	public class ArticleContent
		{
		[Key]
		public int ArticleContentId { get; set; }
		public string ArticleText { get; set; }
		public virtual Article Article { get; set; }
		}
	}
