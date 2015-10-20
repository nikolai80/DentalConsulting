using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using DentalConsultingData;

namespace DentalConsultingDAL
	{

	public class ArticleContentRepository : IArticleContent, IDisposable
		{ 
		private DentalConsultingContext context;

		public ArticleContentRepository(DentalConsultingContext context)
		{
			this.context = context;
		}
		public void Save()
		{
			context.SaveChanges();
		}

		public void DeleteArticleContent(int articleContentId)
			{
			throw new NotImplementedException();
			}

		public void EditArticleContent(ArticleContent articleContent)
			{
			context.Entry(articleContent).State = EntityState.Modified;
			}

		public void InsertArticleContent(ArticleContent articleContent)
			{
			throw new NotImplementedException();
			}

		public ArticleContent GetArticleContent(int articleContentId)
			{
			throw new NotImplementedException();
			}

		


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

		}
}
