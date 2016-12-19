using CzteryPokoje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CzteryPokoje.Controllers
{
    public class HomeController : Controller
    {
        private MyDBContext context = new MyDBContext();
        // GET: Home
        public ActionResult Index()
        {
            return View("Index", context.Offers.ToList());
        }

        public ActionResult Create()
        {
            Offer offer = new Offer();
            return View("Create", offer);
        }

        [HttpPost]
        public ActionResult Create(Offer offer)
        {
            if (ModelState.IsValid)
            {
                context.Offers.Add(offer);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create", offer);
            }
        }
    }
}