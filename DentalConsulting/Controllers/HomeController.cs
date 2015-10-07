using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DentalConsultingData;
using DentalConsultingDAL;

namespace DentalConsulting.Controllers
	{
	public class HomeController : Controller
		{
		private IArticleRepository articleRepository;
		public HomeController() { this.articleRepository = new ArticleRepository(new DentalConsultingContext()); }

		public HomeController(IArticleRepository articleRepository)
			{
			this.articleRepository = articleRepository;
			}
		public ActionResult Index()
			{
			var articles = from a in articleRepository.GetArticles() select a;

			return View(articles.ToList());
			}

		public ActionResult About()
			{
			ViewBag.Message = "Your application description page.";

			return View();
			}

		public ActionResult Contact()
			{
			ViewBag.Message = "Your contact page.";

			return View();
			}


		}
	}