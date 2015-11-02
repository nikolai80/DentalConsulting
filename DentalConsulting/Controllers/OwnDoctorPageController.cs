﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DentalConsulting.Models;
using DentalConsultingData;
using DentalConsultingDAL;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace DentalConsulting.Controllers
	{
	[Authorize(Roles = "doctor")]
    public class OwnDoctorPageController : Controller
    {
		private IArticleRepository articleRepository;
	    private DentalConsultingDAL.IUser userRepository;

	    public OwnDoctorPageController()
	    {
		    this.userRepository = new UserRepository(new DentalConsultingContext());
		    this.articleRepository=new ArticleRepository(new DentalConsultingContext());
	    }

	    public OwnDoctorPageController(DentalConsultingDAL.IUser userRepository,IArticleRepository articleRepository,IArticleContent articleContentRepository)
	    {
		    this.userRepository = userRepository;
		    this.articleRepository = articleRepository;
	    }

	    // GET: OwnDoctorPage
        public ActionResult Index(string userId)
        {
	        if (!String.IsNullOrEmpty(userId))
	        {
		        User user = userRepository.GetUsers().First(u => u.LoggedUserId == userId);
		        return View(user);
	        }
	        else
	        {
		      return  Redirect("/Home/Index");
	        }
        }

		//GET: DoctorArticles
	    public ActionResult GetArticles()
	    {
		    var user = GetLoggedUser();
		var articles = articleRepository.GetArticles().Where(a=>a.UserUserID==user.UserID).ToList();	
		    return View(articles);
	    }
		 //GET:DoctorArticle/2
		public ActionResult EditArticle(int id)
		{
			var article = articleRepository.GetArticleById(id);
			return View(article);
		}

		[HttpPost, ActionName("EditArticle")]
		[ValidateAntiForgeryToken]
		public ActionResult EditArticle(int id,FormCollection formCollection)
		{
		var articleToUpdate = articleRepository.GetArticleById(id);
			if (TryUpdateModel(articleToUpdate))
			{
				articleRepository.EditArticle(articleToUpdate);
			}
			articleRepository.Save();
		return RedirectToAction("GetArticles");
		}

		//GET:CreateArticle
		public ActionResult CreateArticle()
		{
			return View();
		}

		//POST:CreateArticle
		[HttpPost]
		public ActionResult CreateArticle(Article article)
		{
			article.UserUserID = GetLoggedUser().UserID;
		  articleRepository.InsertArticle(article);
		return RedirectToAction("GetArticles");	
		}

		public ActionResult DeleteArticle(int id)
		{
			articleRepository.DeleteArticle(id);
		return RedirectToAction("GetArticles");	
		}

		private User GetLoggedUser()
		{
			User loggedUser = null;
			ApplicationUserManager userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
			ApplicationUser user = userManager.FindByEmail(User.Identity.Name);
			loggedUser = userRepository.GetUsers().First(u => u.LoggedUserId == user.Id);
			return loggedUser;
		}
		protected override void Dispose(bool disposing)
			{
			articleRepository.Dispose();
			base.Dispose(disposing);
			}

    }
}