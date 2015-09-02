using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DentalConsultingData
	{

	public class ArticleRepository : IArticleRepository, IDisposable
	{
		private DataContext context;


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
