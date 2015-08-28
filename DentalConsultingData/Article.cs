using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DentalConsultingData
	{
	public class Article
		{
		public int ArticleId { get; set; }
		public string ArticleTitle { get; set; }
		public ArticleContent ArticleContent { get; set; }
		}
	}
