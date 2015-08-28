using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalConsultingData
	{
	public class ArticleContent
		{
		public int ArticleContentId { get; set; }
		public string ArticleText { get; set; }
		public Article Article { get; set; }
		}
	}
