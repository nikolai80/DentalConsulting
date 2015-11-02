using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DentalConsultingDAL;

namespace DentalConsulting.Controllers
{
    public class DentalCardController : Controller
    {
	    private DentalConsultingDAL.IDentalCard cardRepository;

		public DentalCardController()
			{
			this.cardRepository = new DentalCardRepository(new DentalConsultingContext());
			}

		public DentalCardController(DentalConsultingDAL.IDentalCard cardRepository)
			{
			this.cardRepository = cardRepository;
			}

        // GET: DentalCard
        public ActionResult Index(int id)
        {
	        var dentalCard = cardRepository.GetDentalCardById(id);
            return View(dentalCard);
        }

        // GET: DentalCard/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DentalCard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DentalCard/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DentalCard/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DentalCard/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DentalCard/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DentalCard/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
