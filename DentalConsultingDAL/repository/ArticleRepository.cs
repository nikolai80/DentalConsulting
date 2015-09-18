using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DentalConsultingDAL;

namespace DentalConsultingData
	{

	public class ArticleRepository : IArticleRepository, IDisposable
	{
		private DentalConsultingContext context;


		bool disposed = false;
		protected virtual void Dispose(bool disposing)
			{
			if(!this.disposed)
				{
				if(disposing)
					{
					context.Dispose();
					}
				}
			this.disposed = true;
			}
		public void Dispose()
		{
		Dispose(true);
		GC.SuppressFinalize(this);
		}

		public IEnumerable<Article> GetArticles()
			{
			throw new NotImplementedException();
			}

		public Article GetArticleById(int articleId)
			{
			throw new NotImplementedException();
			}

		public void EditArticle(Article article)
			{
			throw new NotImplementedException();
			}

		public void InsertArticle(Article article)
			{
			throw new NotImplementedException();
			}

		public void DeleteArticle(int articleId)
			{
			throw new NotImplementedException();
			}

		public void Save()
			{
			throw new NotImplementedException();
			}
	}
}
