using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentalConsultingData;

namespace DentalConsultingDAL
	{
	public class DentalConsultingInitializer : System.Data.Entity.DropCreateDatabaseAlways<DentalConsultingContext>
		{
		protected override void Seed(DentalConsultingContext context)
			{
			var articles = new List<Article>
            {
            new Article{ArticleTitle= "Header 1"},
            new Article{ArticleTitle= "Header 2"},
            new Article{ArticleTitle= "Header 3"},
            new Article{ArticleTitle= "Header 4"}
            };

			articles.ForEach(s => context.Articles.Add(s));
			context.SaveChanges();
			var articalContent = new List<ArticleContent>
            {
            new ArticleContent{ArticleText="text1",ArticleID=1},
            new ArticleContent{ArticleText="text2",ArticleID=2},
            new ArticleContent{ArticleText="text3",ArticleID=3},
            new ArticleContent{ArticleText="text4",ArticleID=4}
            };
			articalContent.ForEach(s => context.ArticleContents.Add(s));
			context.SaveChanges();
			
			}
		}
	}
