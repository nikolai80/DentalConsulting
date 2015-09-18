﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DentalConsultingData
	{
	public class Article
		{
		public int ArticleID { get; set; }
		public string ArticleTitle { get; set; }
		public virtual ArticleContent ArticleContent { get; set; }
		}
	}
