using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DentalConsultingData;

namespace DentalConsultingDAL
	{

	public interface IArticleContent
		{

		void Save();

		void DeleteArticleContent(int articleContentId);

		void EditArticleContent(ArticleContent articleContent);

		void InsertArticleContent(ArticleContent articleContent);

		ArticleContent GetArticleContent(int articleContentId);
	}
}
