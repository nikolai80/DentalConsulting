using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DentalConsultingData
	{

	public interface IArticleRepository	:IDisposable
		{

		IEnumerable<Article> GetArticles();

		Article GetArticleById(int articleId);

		void EditArticle(Article article);

		void InsertArticle(Article article);

		void DeleteArticle(int articleId);

		void Save();
	}
}
