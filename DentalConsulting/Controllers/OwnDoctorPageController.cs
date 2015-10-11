using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DentalConsulting.Models;
using DentalConsultingData;
using DentalConsultingDAL;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace DentalConsulting.Controllers
{
    public class OwnDoctorPageController : Controller
    {
		private IArticleRepository articleRepository;
	    private DentalConsultingDAL.IUser userRepository;

	    public OwnDoctorPageController()
	    {
		    this.userRepository = new UserRepository(new DentalConsultingContext());
		    this.articleRepository=new ArticleRepository(new DentalConsultingContext());
	    }

	    public OwnDoctorPageController(DentalConsultingDAL.IUser userRepository,DentalConsultingDAL.IArticleRepository articleRepository)
	    {
		    this.userRepository = userRepository;
		    this.articleRepository = articleRepository;
	    }

	    // GET: OwnDoctorPage
        public ActionResult Index()
        {
            return View();
        }

		//GET: DoctorArticles
		[Authorize(Roles="doctor")]
	    public ActionResult GetArticles()
		{
			ApplicationUserManager userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
			ApplicationUser user = userManager.FindByEmail(User.Identity.Name);
			User appUser = userRepository.GetUsers().First(u => u.LoggedUserId == user.Id);
			var articles = articleRepository.GetArticles().Where(a => a.UserUserID == appUser.UserID);	
		    return View(articles.ToList());
	    }
    }
}