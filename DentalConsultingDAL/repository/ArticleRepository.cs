using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using DentalConsultingData;

namespace DentalConsultingDAL
	{

	public class ArticleRepository : IArticleRepository, IDisposable
		{
		private DentalConsultingContext context;

		public ArticleRepository(DentalConsultingContext context)
			{
			this.context = context;
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

		public IEnumerable<Article> GetArticles()
			{
			var articles = context.Articles.Include(a => a.ArticleContent);
			return articles.ToList();
			}

		//public IEnumerable<Article> GetArticlesByUserId(int userId)
		//	{
		//	var articles = context.Articles.Include(a => a.ArticleContent).Where(a=>a.UserUserID==userId);
		//	return articles.ToList();
		//	}
		public Article GetArticleById(int articleId)
			{
			var article = context.Articles.Find(articleId);
			return article;
			}

		public void EditArticle(Article article)
			{
			context.Entry(article).State = EntityState.Modified;
			}

		public void InsertArticle(Article article)
			{
			context.Articles.Add(article);
			}

		public void DeleteArticle(int articleId)
			{
			Article article = context.Articles.Find(articleId);
			context.Articles.Remove(article);
			}

		public void Save()
			{
			context.SaveChanges();
			}
		}
	}
