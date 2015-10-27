using System;
using System.Collections.Generic;
using System.Data;
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

		public Article GetArticleById(int articleId)
			{
			var article = context.Articles.Include(a=>a.ArticleContent).Single(a => a.ArticleID==articleId);
			return article;
			}

		public void EditArticle(Article article)
		{
			
			try
				{
				context.Entry(article).State = EntityState.Modified;
				context.SaveChanges();
				}
			catch(DataException ex)
				{
				//Log the error (add a variable name after DataException) 
				//ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
				}
			}

		public void InsertArticle(Article article)
			{
			try
			{
				context.Articles.Add(article);
				context.SaveChanges();
			}
			catch (DataException)
			{
				
			}
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
